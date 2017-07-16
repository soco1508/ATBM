using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATBMChuong3
{
    class ThuatToanA51
    {
        public bool[] X;
        public bool[] Y;
        public bool[] Z;
        public BitArray banro;

        //Hàm major lấy bit chiếm đa số
        private bool Maj(bool x8, bool y10, bool z10)
        {
            int dem = 0;
            if (x8 == true) dem++;
            if (y10 == true) dem++;
            if (z10 == true) dem++;
            if (dem >= 2) return true;
            else return false;
        }

        //Hàm quay X
        private bool[] QuayX(bool[] x)
        {
            bool t = x[13] ^ x[16] ^ x[17] ^ x[18];
            for (int i = 18; i > 0; i--)
                x[i] = x[i - 1];
            x[0] = t;
            return x;
        }

        //Hàm quay Y
        private bool[] QuayY(bool[] y)
        {
            bool t = y[20] ^ y[21];
            for (int i = 21; i > 0; i--)
                y[i] = y[i - 1];
            y[0] = t;
            return y;
        }

        //Hàm quay Z
        private bool[] QuayZ(bool[] z)
        {
            bool t = z[7] ^ z[20] ^ z[21] ^ z[22];
            for (int i = 22; i > 0; i--)
                z[i] = z[i - 1];
            z[0] = t;
            return z;
        }

        //Hàm sinh số ngẫu nhiên
        private bool[] SinhSoNgauNhien()
        {
            bool m = true;
            bool[] bit = new bool[banro.Length];
            for (int i = 0; i < banro.Length; i++)
            {
                m = Maj(X[8], Y[10], Z[10]);
                if (X[8] == m) X = QuayX(X);
                if (Y[10] == m) Y = QuayY(Y);
                if (Z[10] == m) Z = QuayZ(Z);
                bit[i] = X[18] ^ Y[21] ^ Z[22];
            }
            return bit;
        }

        // Hàm mã hóa
        public BitArray MaHoa()
        {
            BitArray khoa = new BitArray(SinhSoNgauNhien());
            for (int i = 0; i < banro.Length; i++)
            {
                banro[i] ^= khoa[i];
            }
            return banro;
        }
    }
}
