using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATBMChuong3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "All files (*) | *";
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName != " ")
            {
                try
                {
                    txtInput.Text = openFileDialog1.FileName;
                    txtOutput.Text = openFileDialog1.FileName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.StackTrace);
                }
            }
        }

        private void btnOutput_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "All files (*)|*";
            saveFileDialog1.ShowDialog();
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.FileName != "")
            {
                try
                {
                    txtOutput.Text = saveFileDialog1.FileName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.StackTrace);
                }
            }
        }

        //Hàm chuyển mảng khóa từ kiểu string sang mảng bool
        private bool[] ChuyenDoi(string S)
        {
            bool[] bit = new bool[S.Length];
            for (int i = 0; i < S.Length; i++)
            {
                if (S[i] == '0') bit[i] = false;
                else bit[i] = true;
            }
            return bit;
        }

        //Chuuyển một mảng bit sang mảng byte
        private byte[] BitArrayToByteArray(BitArray bits)
        {
            byte[] ret = new byte[bits.Length / 8];
            bits.CopyTo(ret, 0);
            return ret;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtInput.Text != "" & txtOutput.Text != "" & txtKhoaX.TextLength == 19 & txtKhoaY.TextLength == 22 & txtKhoaZ.TextLength == 23)
                {
                    ThuatToanA51 A51 = new ThuatToanA51();
                    A51.X = ChuyenDoi(txtKhoaX.Text);
                    A51.Y = ChuyenDoi(txtKhoaY.Text);
                    A51.Z = ChuyenDoi(txtKhoaZ.Text);
                    A51.banro = new BitArray(File.ReadAllBytes(txtInput.Text));

                    byte[] BanMa = BitArrayToByteArray(A51.MaHoa());
                    try
                    {
                        File.WriteAllBytes(txtOutput.Text, BanMa);
                        MessageBox.Show("Thực hiện thành công");
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }
                }
                else
                {
                    if (txtInput.Text == "") MessageBox.Show("Chưa chọn file !!");
                    if (txtOutput.Text == "") MessageBox.Show("Chưa chọn đường dẫn lưu file !!");
                    if (txtKhoaX.TextLength != 19 || txtKhoaY.TextLength != 22 || txtKhoaZ.TextLength != 23) MessageBox.Show("Khóa chưa đúng");
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private string SinhKhoa(int lenght)
        {
            string S = "";
            Random ran = new Random();
            for (int i = 0; i < lenght; i++)
                S += (ran.Next(2));
            return S;
        }

        private void btnSinhKhoa_Click(object sender, EventArgs e)
        {
            txtKhoaX.Text = SinhKhoa(19);
            txtKhoaY.Text = SinhKhoa(22);
            txtKhoaZ.Text = SinhKhoa(23);
        }

        private void txtKhoaX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ("01".IndexOf(e.KeyChar) != -1 || char.IsControl(e.KeyChar)) { e.Handled = false; }
            else e.Handled = true;
        }

        private void txtKhoaY_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ("01".IndexOf(e.KeyChar) != -1 || char.IsControl(e.KeyChar)) { e.Handled = false; }
            else e.Handled = true;
        }

        private void txtKhoaZ_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ("01".IndexOf(e.KeyChar) != -1 || char.IsControl(e.KeyChar)) { e.Handled = false; }
            else e.Handled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }       

    }
}
