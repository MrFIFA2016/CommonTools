using CommonTools.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonTools
{
    public class CodeUtil
    {
        public static string GenJavaCode(string className, string functionName, string param, List<Object> checkedItems, int paramCount, int workId)
        {
            string reStr = "";
            string javaTemplate = "console.log('Script loaded successfully ');\n"
               + "Java.perform(function() {{ \n"
               + "   console.log('Inside java perform function');\n"
               + "   var className = '{0}'; \n"
               + "   var Resources = Java.use(className);\n"
               + "   Resources.{2}.overload({6}).implementation = function({3}) {{\n"
               + "   console.log('Java.Use.Successfully! 打印参数：');//定位类成功！\n"
               + "   {1}\n"
               + "   var retval = this.{2}({3}); \n"
               + "   {4} \n"
               + "   {5} \n"
               + "   return retval;\n"
               + "   }}\n"
               + "}}); ";

            string[] args = new string[] { "a", "b", "c", "d", "e" };
            string pp = "";

            for (int i = 0; i < paramCount; i++)
            {
                pp += args[i];
                if (i != paramCount - 1)
                {
                    pp += ",";
                }
            }

            string paramStr = "";
            string stackInto = "";
            if (((JavaParaItem)checkedItems[0]).ValuePrint)
            {
                stackInto = "console.log('Backtrace:\t' + Java.use(\"android.util.Log\").getStackTraceString(Java.use(\"java.lang.Exception\").$new())";
            }

            string ret = "";
            if (((JavaParaItem)checkedItems[1]).ValuePrint)
                ret = "console.log('函数执行结果：' + retval);";

            for (int i = 2; i < checkedItems.Count; i++)
            {
                JavaParaItem item = (JavaParaItem)checkedItems[i];
                if (item == null || !item.ValuePrint)
                    continue;

                string s = "console.log('参数打印 param{0}: ', {1});\n";
                if (paramStr != "")
                    s = "   " + s;
                paramStr += string.Format(s, i - 2, args[i - 2]);

            }
            if (!String.IsNullOrEmpty(param))
                param = "'" + param + "'";
            reStr = string.Format(javaTemplate, className, paramStr, functionName, pp, ret, stackInto, param);

            return reStr;
        }

        public static string GenNativeCode(string modelName, string address, List<Object> checkedItems, int workId)
        {
            string reStr = "";

            string soTemplate = "\nvar baseAddr = Module.findBaseAddress('{0}');\n"
                + "console.log(baseAddr)\n"
                + "var luaL_loadbuffer = baseAddr.add({1});\n"
                + "\n"
                + "Interceptor.attach(luaL_loadbuffer,{{\n"
                + "\tonEnter:function(args){{\n"
                + "       try{{\n"
                + "\t\t\t{2} \n"
                + "\t\t\t{3} \n"
                + "\t\t\t{6} \n"
                + "        }}catch(e){{\n"
                + "            console.log(e);\n"
                + "        }}\n"
                + "\t}},\n"
                + "\tonLeave:function(retval){{\n"
                + "       try{{\n"
                + "            {4} \n"
                + "            {5} \n"
                + "       }}catch(e){{\n"
                + "            console.log(e);\n"
                + "       }}\n"
                + "\t}}\n"
                + "}});";

            soTemplate = soTemplate.Replace("baseAddr", "baseAddr_" + workId);
            soTemplate = soTemplate.Replace("luaL_loadbuffer", "luaL_loadbuffer_" + workId);

            string paramStr = "";
            string stackInfo = "";
            if (((NativeParaItem)checkedItems[0]).ValuePrint)
            {
                stackInfo = "console.log('Backtrace:\t' + Thread.backtrace(this.context,Backtracer.ACCURATE).map(DebugSymbol.fromAddress).join(''));";
            }

            string ret = "";
            if (((NativeParaItem)checkedItems[1]).ValuePrint)
                ret = "console.log('函数执行结果：' + retval);";

            string outsetVar = "";
            string leavePara = "";

            for (int i = 2; i < checkedItems.Count; i++)
            {
                NativeParaItem item = (NativeParaItem)checkedItems[i];
                if (item == null || !item.ValuePrint)
                    continue;

                string s = "\n\t\t\t" + "console.log('参数打印 param{0}:', args[{0}]);\n";
                if (paramStr != "")
                    s = "\t\t\t" + s;
                paramStr += string.Format(s, i - 2);
                if (item.MemPrint)
                {
                    string arg = "this.a" + workId + "_" + (i - 2);
                    s = arg + " = args[" + (i - 2) + "];\n";
                    if (outsetVar != "")
                        s = "\t\t\t" + s;
                    outsetVar += s;

                    s = "\t\t\t" + "console.log(Memory.readByteArray(args[{0}],{1}));\n";
                    paramStr += string.Format(s, i - 2, item.MemLen);

                    s = "\n\t\t\t" + "console.log({0});\n"
                        + "\t\t\t" + "console.log(Memory.readByteArray({0}, {1}));\n";
                    if (leavePara != "")
                        s = "\t\t\t" + s;
                    leavePara += string.Format(s, arg, item.MemLen);
                }
                if (item.MemU64Print)
                {
                    s = "\t\t\t" + "var p{0} = ptr(ptr(parseInt(args[{0}])).readU64());\n"
                        + "\t\t\t" + "console.log(Memory.readByteArray(p{0}, {1})); \n";
                    paramStr += string.Format(s, i - 2, item.Mem64Len);
                }

            }
            reStr = string.Format(soTemplate, modelName, address, stackInfo, paramStr, ret, leavePara, outsetVar);

            return reStr;
        }

        private static string GenCode(string hookType, string templateStr, string className, string functionName, string param, List<NativeParaItem> checkedItems, int paramCount, int workId)
        {
            string reStr = "";
            string javaTemplate = "console.log('Script loaded successfully ');\n"
               + "Java.perform(function() {{ \n"
               + "   console.log('Inside java perform function');\n"
               + "   var className = '{0}'; \n"
               + "   var Resources = Java.use(className);\n"
               + "   Resources.{2}.overload({6}).implementation = function({3}) {{\n"
               + "   console.log('Java.Use.Successfully! 打印参数：');//定位类成功！\n"
               + "   {1}\n"
               + "   var retval = this.{2}({3}); \n"
               + "   {4} \n"
               + "   {5} \n"
               + "   return retval;\n"
               + "   }}\n"
               + "}}); ";

            string soTemplate = "\nvar baseAddr = Module.findBaseAddress('{0}');\n"
                + "console.log(baseAddr)\n"
                + "var luaL_loadbuffer = baseAddr.add({1});\n"
                + "\n"
                + "Interceptor.attach(luaL_loadbuffer,{{\n"
                + "\tonEnter:function(args){{\n"
                + "       try{{\n"
                + "\t\t\t{2} \n"
                + "\t\t\t{3} \n"
                + "\t\t\t{6} \n"
                + "        }}catch(e){{\n"
                + "            console.log(e);\n"
                + "        }}\n"
                + "\t}},\n"
                + "\tonLeave:function(retval){{\n"
                + "       try{{\n"
                + "            {4} \n"
                + "            {5} \n"
                + "       }}catch(e){{\n"
                + "            console.log(e);\n"
                + "       }}\n"
                + "\t}}\n"
                + "}});";

            soTemplate = soTemplate.Replace("baseAddr", "baseAddr_" + workId);
            soTemplate = soTemplate.Replace("luaL_loadbuffer", "luaL_loadbuffer_" + workId);

            string[] args = new string[] { "a", "b", "c", "d", "e" };
            string pp = "";

            for (int i = 0; i < paramCount; i++)
            {
                pp += args[i];
                if (i != paramCount - 1)
                {
                    pp += ",";
                }
            }

            string paramStr = "";
            string zdNative = "";
            string zdJava = "";
            if (checkedItems[0].ValuePrint)
            {
                zdNative = "console.log('Backtrace:\t' + Thread.backtrace(this.context,Backtracer.ACCURATE).map(DebugSymbol.fromAddress).join(''));";
                zdJava = "console.log('Backtrace:\t' + Java.use(\"android.util.Log\").getStackTraceString(Java.use(\"java.lang.Exception\").$new())";
            }

            string ret = "";
            if (checkedItems[1].ValuePrint)
                ret = "console.log('函数执行结果：' + retval);";

            string outsetVar = "";
            string leavePara = "";

            for (int i = 2; i < checkedItems.Count; i++)
            {
                if (!checkedItems[i].ValuePrint)
                    continue;

                if (hookType == "java")
                {
                    string s = "console.log('参数打印 param{0}: ', {1});\n";
                    if (paramStr != "")
                        s = "   " + s;
                    paramStr += string.Format(s, i - 2, args[i - 2]);
                }
                else
                {
                    string s = "\n\t\t\t" + "console.log('参数打印 param{0}:', args[{0}]);\n";
                    if (paramStr != "")
                        s = "\t\t\t" + s;
                    paramStr += string.Format(s, i - 2);
                    if (checkedItems[i].MemPrint)
                    {
                        string arg = "this.a" + workId + "_" + (i - 2);
                        s = arg + " = args[" + (i - 2) + "];\n";
                        if (outsetVar != "")
                            s = "\t\t\t" + s;
                        outsetVar += s;

                        s = "\t\t\t" + "console.log(Memory.readByteArray(args[{0}],{1}));\n";
                        paramStr += string.Format(s, i - 2, checkedItems[i].MemLen);

                        s = "\n\t\t\t" + "console.log({0});\n"
                            + "\t\t\t" + "console.log(Memory.readByteArray({0}, {1}));\n";
                        if (leavePara != "")
                            s = "\t\t\t" + s;
                        leavePara += string.Format(s, arg, checkedItems[i].MemLen);
                    }
                    if (checkedItems[i].MemU64Print)
                    {
                        s = "\t\t\t" + "var p{0} = ptr(ptr(parseInt(args[{0}])).readU64());\n"
                            + "\t\t\t" + "console.log(Memory.readByteArray(p{0}, {1})); \n";
                        paramStr += string.Format(s, i - 2, checkedItems[i].Mem64Len);
                    }
                }
            }

            switch (hookType)
            {
                case "java":
                    {
                        if (!String.IsNullOrEmpty(param))
                            param = "'" + param + "'";
                        reStr = string.Format(javaTemplate, className, paramStr, functionName, pp, ret, zdJava, param);
                        break;
                    }
                case "native":
                    {
                        reStr = string.Format(soTemplate, className, functionName, zdNative, paramStr, ret, leavePara, outsetVar);
                        break;
                    }
                case "address":
                    {
                        break;
                    }
                default:
                    break;
            }

            return reStr;
        }
    }
}
