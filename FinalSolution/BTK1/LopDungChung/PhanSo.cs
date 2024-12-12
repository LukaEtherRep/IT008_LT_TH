using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTK1.LopDungChung
{
    internal class PhanSo
    {
        // Định nghĩa lớp PS có 2 thuộc tính: TuSo và MauSo
        // 1. Dữ liệu
        private int tuSo, mauSo;
        // 2.Thuộc tính
        public int TuSo { get => tuSo; set => tuSo = value; }
        public int MauSo { get => mauSo; set => mauSo = value; }
        // 3. Phương thức khởi tạo
        public PhanSo()
        {
            tuSo = 0;
            mauSo = 0;
        }

        public PhanSo(int ts, int ms)
        {
            tuSo = ts;
            mauSo = ms;
            if (ms == 0)
                throw new Exception("Mẫu số không được bằng 0");
        }
        // 4. Phương thức thành viên
        private void RutGon()
        {
            int uocSoChungLN;
            uocSoChungLN = LopToanHocDungChung.USCLN(tuSo, mauSo);
            if (uocSoChungLN > 0)
            {
                tuSo /= uocSoChungLN;
                mauSo /= uocSoChungLN;
            }
        }

        public PhanSo Cong(PhanSo ps)
        {
            PhanSo ketQua = new PhanSo();
            ketQua.tuSo = tuSo * ps.mauSo + ps.tuSo * mauSo;
            ketQua.mauSo = mauSo * ps.mauSo;
            ketQua.RutGon();
            return ketQua;
        }

        public PhanSo Tru(PhanSo ps)
        {
            PhanSo ketQua = new PhanSo();
            ketQua.tuSo = tuSo * ps.mauSo - ps.tuSo * mauSo;
            ketQua.mauSo = mauSo * ps.mauSo;
            ketQua.RutGon();
            return ketQua;
        }

        public PhanSo Nhan(PhanSo ps)
        {
            PhanSo ketQua = new PhanSo();
            ketQua.tuSo = tuSo * ps.tuSo;
            ketQua.mauSo = mauSo * ps.mauSo;
            ketQua.RutGon();
            return ketQua;
        }

        public PhanSo Chia(PhanSo ps)
        {
            PhanSo ketQua = new PhanSo();
            ketQua.tuSo = tuSo * ps.mauSo;
            ketQua.mauSo = mauSo * ps.TuSo;
            ketQua.RutGon();
            return ketQua;
        }
    }
}
