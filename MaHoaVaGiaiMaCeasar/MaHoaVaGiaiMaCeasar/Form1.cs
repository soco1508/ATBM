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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private char maHoa(char ch, int key)
        {
            if (Char.IsLetter(ch))
            {
                ch = (char) ('A' + (Char.ToUpper(ch) - 'A' + key) % 26);
            }
            return ch;
        }

        private void button2_Click(object sender, EventArgs e)
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

        private void btnMaHoa_Click(object sender, EventArgs e)
        {
            String ro = txtRo.Text;
            String k = txtKhoa.Text;
            int key;
            key = Int32.Parse(k);
            String rs = string.Empty;
            for (int i = 0; i < ro.Length; i++)
            {
                char ch = maHoa(ro[i], key);
                rs = rs + ch;
            }
            txtMa.Text = rs.ToString();
        }

        private void btnGiaiMa_Click(object sender, EventArgs e)
        {
            String ma = txtMa.Text;
            String k = txtKhoa.Text;
            int key;
            key = Int32.Parse(k);
            String rs = string.Empty;
            for (int i = 0; i < ma.Length; i++)
            {
                char ch = maHoa(ma[i], key);
                rs = rs + ch;
            }
            txtRo.Text = rs.ToString();
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
