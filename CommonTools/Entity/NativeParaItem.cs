using System;

namespace CommonTools.Entity
{
    public class NativeParaItem : ParaItem
    {
        Boolean memPrint = false;
        Boolean memU64Print = false;
        UInt32 memLen = 0;
        UInt32 mem64Len = 0;
        Boolean valuePrint = false;


        public bool MemPrint { get => memPrint; set => memPrint = value; }
        public bool MemU64Print { get => memU64Print; set => memU64Print = value; }
        public uint MemLen { get => memLen; set => memLen = value; }
        public uint Mem64Len { get => mem64Len; set => mem64Len = value; }
        public bool ValuePrint { get => valuePrint; set => valuePrint = value; }

        public override string ToString()
        {
            return String.Format("ValuePrint={0} MemPrint={1} MemU64Print={2} memLen={3} mem64Len={4}", ValuePrint, memPrint, memU64Print, memLen, mem64Len);
        }
    }
}
