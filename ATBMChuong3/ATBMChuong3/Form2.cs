using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;

namespace ATBMChuong3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        static string sKey;
        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void EncryptFile(string source, string destination, string sKey)
        {
            FileStream fsInput = new FileStream(source,
                FileMode.Open,
                FileAccess.Read);

            FileStream fsEncrypted = new FileStream(destination,
                            FileMode.Create,
                            FileAccess.Write);

            DESCryptoServiceProvider DES = new DESCryptoServiceProvider();
            DES.Key = ASCIIEncoding.ASCII.GetBytes(sKey);
            DES.IV = ASCIIEncoding.ASCII.GetBytes(sKey);
            ICryptoTransform desencrypt = DES.CreateEncryptor();
            CryptoStream cryptostream = new CryptoStream(fsEncrypted,
                                desencrypt,
                                CryptoStreamMode.Write);
            byte[] bytearrayinput = new byte[fsInput.Length];
            fsInput.Read(bytearrayinput, 0, bytearrayinput.Length);
            cryptostream.Write(bytearrayinput, 0, bytearrayinput.Length);
            cryptostream.Close();
            fsInput.Close();
            fsEncrypted.Close();
        }
        private void DecryptFile(string source, string destination, string sKey)
        {           
            DESCryptoServiceProvider DES = new DESCryptoServiceProvider();
            //A 64 bit key and IV is required for this provider.
            //Set secret key For DES algorithm.
            DES.Key = ASCIIEncoding.ASCII.GetBytes(sKey);
            //Set initialization vector.
            DES.IV = ASCIIEncoding.ASCII.GetBytes(sKey);

            //Create a file stream to read the encrypted file back.
            FileStream fsread = new FileStream(source,
                                           FileMode.Open,
                                           FileAccess.Read);
            //Create a DES decryptor from the DES instance.
            ICryptoTransform desdecrypt = DES.CreateDecryptor();
            //Create crypto stream set to read and do a 
            //DES decryption transform on incoming bytes.
            CryptoStream cryptostreamDecr = new CryptoStream(fsread,
                                                         desdecrypt,
                                                         CryptoStreamMode.Read);
            //Print the contents of the decrypted file.
            StreamWriter fsDecrypted = new StreamWriter(destination);           
            fsDecrypted.Write(new StreamReader(cryptostreamDecr).ReadToEnd());            
            fsDecrypted.Flush();
            fsDecrypted.Close();
        }
        //function to generate a 64 bit key
        private string GenerateKey()
        {
            // Create an instance of Symetric Algorithm. Key and IV is generated automatically.
            DESCryptoServiceProvider desCrypto = (DESCryptoServiceProvider)DESCryptoServiceProvider.Create();
            // Set key to a pre-determined set of bytes (of length 8):
            desCrypto.Key = new byte[] { 0x4b, 0x4a, 0x41, 0x52, 0x54, 0x41, 0x4e, 0x21 };
            // Use the Automatically generated key for Encryption. 
            return ASCIIEncoding.ASCII.GetString(desCrypto.Key);

        }
        OpenFileDialog openFileDialog1;
        SaveFileDialog saveFileDialog1;
        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            sKey = GenerateKey();
            openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string source = openFileDialog1.FileName;
                saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "des files |*.des";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string destination = saveFileDialog1.FileName;
                    EncryptFile(source, destination, sKey);
                    lbKey.Text = "Key: " + sKey;
                }

            }           
            MessageBox.Show("Mã hóa thành công!");
        }
       

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "des files |*.des";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string source = openFileDialog1.FileName;
                saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "des files |*.des";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string destination = saveFileDialog1.FileName;
                    DecryptFile(source, destination, sKey);
                }
            }
            MessageBox.Show("Giải mã thành công!");
        }
    }
}
