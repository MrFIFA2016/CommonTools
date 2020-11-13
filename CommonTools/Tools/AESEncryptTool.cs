using ICSharpCode.TextEditor;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommonTools.Tools
{
    public class AESEncryptTool : StripTool
    {
        ToolStripTextBox keytxtBox;
        ToolStripTextBox vectorTxtBox;

        public AESEncryptTool(ToolStrip toolStrip, TextEditorControl inputBox, TextEditorControl outputBox) :
            base(toolStrip, inputBox, outputBox)
        {
            init();
        }

        protected override void init()
        {
            this.toolStrip.Items.Clear();

            ToolStripLabel keyLable = new ToolStripLabel
            {
                Text = "密钥:"
            };
            this.toolStrip.Items.Add(keyLable);

            keytxtBox = new ToolStripTextBox
            {
                Size = new System.Drawing.Size(120, toolStrip.Height - 4)
            };
            this.toolStrip.Items.Add(keytxtBox);

            ToolStripLabel keyLable2 = new ToolStripLabel
            {
                Text = "向量:"
            };
            this.toolStrip.Items.Add(keyLable2);

            vectorTxtBox = new ToolStripTextBox
            {
                Size = new System.Drawing.Size(120, toolStrip.Height - 4)
            };
            this.toolStrip.Items.Add(vectorTxtBox);

            ToolStripButton btn1 = new ToolStripButton
            {
                Text = "加密"
            };
            this.toolStrip.Items.Add(btn1);
            btn1.Click += EncryptBtn_Click;

            ToolStripButton btn2 = new ToolStripButton
            {
                Text = "解密"
            };
            this.toolStrip.Items.Add(btn2);
            btn2.Click += Decrypt_Click;
        }

        private void Decrypt_Click(object sender, EventArgs e)
        {
            string input = inputBox.Text.Trim();
            string vector = vectorTxtBox.Text.Trim();
            string output = "";
            if (String.IsNullOrEmpty(vector))
                output = Decrypt(input, keytxtBox.Text.Trim());
            else
                output = Decrypt(input, keytxtBox.Text.Trim(), vector);
            outputBox.Text = output;
            outputBox.Refresh();
        }

        private void EncryptBtn_Click(object sender, EventArgs e)
        {
            string input = inputBox.Text.Trim();
            string vector = vectorTxtBox.Text.Trim();
            string output = "";
            if (String.IsNullOrEmpty(vector))
                output = Encrypt(input, keytxtBox.Text.Trim());
            else
                output = Encrypt(input, keytxtBox.Text.Trim(), vector);
            outputBox.Text = output;
            outputBox.Refresh();
        }


        public static string Encrypt(string str, string key, string vector)
        {
            Byte[] keyArray = Encoding.UTF8.GetBytes(key);
            Byte[] toEncryptArray = Encoding.UTF8.GetBytes(str);
            var rijndael = new RijndaelManaged();
            rijndael.Key = keyArray;
            rijndael.Mode = CipherMode.ECB;
            rijndael.Padding = PaddingMode.PKCS7;
            rijndael.IV = Encoding.UTF8.GetBytes(vector);
            ICryptoTransform cTransform = rijndael.CreateEncryptor();
            Byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);
            return Convert.ToBase64String(resultArray, 0, resultArray.Length);
        }

        /// <summary>
        /// AES解密
        /// </summary>
        /// <param name="str">需要解密的字符串</param>
        /// <param name="key">32位密钥</param>
        /// <returns>解密后的字符串</returns>
        public static string Decrypt(string str, string key, string vector)
        {
            Byte[] keyArray = Encoding.UTF8.GetBytes(key);
            Byte[] toEncryptArray = Convert.FromBase64String(str);
            var rijndael = new RijndaelManaged();
            rijndael.Key = keyArray;
            rijndael.Mode = CipherMode.ECB;
            rijndael.Padding = PaddingMode.PKCS7;
            rijndael.IV = Encoding.UTF8.GetBytes(vector);
            ICryptoTransform cTransform = rijndael.CreateDecryptor();
            Byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);
            return Encoding.UTF8.GetString(resultArray);
        }

        /// <summary>
        /// AES加密(无向量)
        /// </summary>
        /// <param name="plainBytes">被加密的明文</param>
        /// <param name="key">密钥</param>
        /// <returns>密文</returns>
        public static string Encrypt(String Data, String Key)
        {
            MemoryStream mStream = new MemoryStream();
            RijndaelManaged aes = new RijndaelManaged();

            byte[] plainBytes = Encoding.UTF8.GetBytes(Data);
            Byte[] bKey = new Byte[32];
            Array.Copy(Encoding.UTF8.GetBytes(Key.PadRight(bKey.Length)), bKey, bKey.Length);

            aes.Mode = CipherMode.ECB;
            aes.Padding = PaddingMode.PKCS7;
            aes.KeySize = 128;
            //aes.Key = _key;
            aes.Key = bKey;
            //aes.IV = _iV;
            CryptoStream cryptoStream = new CryptoStream(mStream, aes.CreateEncryptor(), CryptoStreamMode.Write);
            try
            {
                cryptoStream.Write(plainBytes, 0, plainBytes.Length);
                cryptoStream.FlushFinalBlock();
                return Convert.ToBase64String(mStream.ToArray());
            }
            finally
            {
                cryptoStream.Close();
                mStream.Close();
                aes.Clear();
            }
        }


        /// <summary>
        /// AES解密(无向量)
        /// </summary>
        /// <param name="encryptedBytes">被加密的明文</param>
        /// <param name="key">密钥</param>
        /// <returns>明文</returns>
        public static string Decrypt(String Data, String Key)
        {
            Byte[] encryptedBytes = Convert.FromBase64String(Data);
            Byte[] bKey = new Byte[32];
            Array.Copy(Encoding.UTF8.GetBytes(Key.PadRight(bKey.Length)), bKey, bKey.Length);

            MemoryStream mStream = new MemoryStream(encryptedBytes);
            //mStream.Write( encryptedBytes, 0, encryptedBytes.Length );
            //mStream.Seek( 0, SeekOrigin.Begin );
            RijndaelManaged aes = new RijndaelManaged();
            aes.Mode = CipherMode.ECB;
            aes.Padding = PaddingMode.PKCS7;
            aes.KeySize = 128;
            aes.Key = bKey;
            //aes.IV = _iV;
            CryptoStream cryptoStream = new CryptoStream(mStream, aes.CreateDecryptor(), CryptoStreamMode.Read);
            try
            {
                byte[] tmp = new byte[encryptedBytes.Length + 32];
                int len = cryptoStream.Read(tmp, 0, encryptedBytes.Length + 32);
                byte[] ret = new byte[len];
                Array.Copy(tmp, 0, ret, 0, len);
                return Encoding.UTF8.GetString(ret);
            }
            finally
            {
                cryptoStream.Close();
                mStream.Close();
                aes.Clear();
            }
        }

    }
}
