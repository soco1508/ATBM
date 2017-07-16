using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaHoaVaGiaiMaCeasar
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
      
        private static void VigenereEncrypt(ref StringBuilder s, string key)
        {
            
            for (int i = 0;i < s.Length; i++) 
                s[i] = Char.ToUpper(s[i]);            
            key = key.ToUpper();           
            int j = 0;
            for (int i = 0; i < s.Length; i++)           
            {            
                if (Char.IsLetter(s[i]))
                {
                    s[i] = (char)(s[i] + key[j] - 'A');                  
                    if (s[i] > 'Z') 
                    s[i] = (char)(s[i] - 'Z' + 'A' - 1);            
                }            
                j = j + 1 == key.Length ? 0 : j + 1; //neu j+=1 == key.length thi quay lai ky tu dau cua key            
            }           
        }
            
        private static void VigenereDecrypt(ref StringBuilder s, string key)            
        {            
            for (int i = 0; i < s.Length; i++) s[i] = Char.ToUpper(s[i]);            
            key = key.ToUpper();            
            int j = 0;            
            for (int i = 0; i < s.Length; i++)            
            {            
                if (Char.IsLetter(s[i]))          
                {           
                    s[i] = s[i] >= key[j] ?            
                                    (char)(s[i] - key[j] + 'A') :            
                                    (char)('Z' - key[j] + s[i] + 1);           
                }               
                j = j + 1 == key.Length ? 0 : j + 1;            
            }
        }
                 
        private void btnMaHoa_Click(object sender, EventArgs e)
        {
            
            string key = txtKhoa.Text;
            StringBuilder encrypt = new StringBuilder(txtRo.Text);
            VigenereEncrypt(ref encrypt, key);
            txtMa.Text = encrypt.ToString();
        }

        private void btnGiaiMa_Click(object sender, EventArgs e)
        {
            string key = txtKhoa.Text;
            StringBuilder decrypt = new StringBuilder(txtMa.Text);
            VigenereDecrypt(ref decrypt, key);
            txtRo.Text = decrypt.ToString();
        }

        private void btnGhiFile_Click(object sender, EventArgs e)
        {
            String path = "C:\\Users\\DONG\\Desktop\\ATBM\\banma.txt";
            var filestream = new System.IO.FileStream(path,
                                          System.IO.FileMode.Open,
                                          System.IO.FileAccess.Read,
                                          System.IO.FileShare.ReadWrite);
            var file = new System.IO.StreamReader(filestream, System.Text.Encoding.UTF8, true, 128);
            String lineOfText;
            while ((lineOfText = file.ReadLine()) != null)
            {
                //Do something with the lineOfText
                txtRo.Text = lineOfText;
            }
        }

        private void btnDocFile_Click(object sender, EventArgs e)
        {
            String path = "C:\\Users\\DONG\\Desktop\\ATBM\\banro.txt";
            var filestream = new System.IO.FileStream(path,
                                          System.IO.FileMode.Open,
                                          System.IO.FileAccess.Read,
                                          System.IO.FileShare.ReadWrite);
            var file = new System.IO.StreamReader(filestream, System.Text.Encoding.UTF8, true, 128);
            String lineOfText;
            while ((lineOfText = file.ReadLine()) != null)
            {
                //Do something with the lineOfText
                txtMa.Text = lineOfText;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
