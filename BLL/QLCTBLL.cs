using DoAnPBL3.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnPBL3.BLL
{
    class QLCTBLL
    {
        private static QLCTBLL _Instance;
        public static QLCTBLL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new QLCTBLL();
                }
                return _Instance;
            }
            private set { _Instance = value; }
        }
        public List<string> GetAll_TenNV()
        {
            QLNH_DB db = new QLNH_DB();
            var tennv = db.NHANVIENs.Select(p => p.tenNV);
            return tennv.Distinct().ToList();
        }
        public List<CHITIETCALAM> GetAll_CaTruc(DateTime ngaylam)
        {
            QLNH_DB db = new QLNH_DB();
           
            var ct = db.CHITIETCALAMs.Where(p => p.ngayLam == ngaylam).ToList();
            return ct;
        }
        public void Add(CHITIETCALAM ct)
        {
            QLNH_DB db = new QLNH_DB();
            string lastID = db.CHITIETCALAMs.OrderByDescending(p => p.maCT).Select(p => p.maCT).FirstOrDefault();
            string nextID = "";
            if (lastID != "")
            {
                int num = int.Parse(lastID.Replace("CT", ""));
                num++;
                nextID = "CT" + num.ToString("D3");
            }
            ct.maCT = nextID;
            db.CHITIETCALAMs.Add(ct);
            db.SaveChanges();
        }
        public void Update(CHITIETCALAM ct)
        {
            QLNH_DB db = new QLNH_DB();
            CHITIETCALAM d = db.CHITIETCALAMs.Find(ct.maCT);
            if (d != null)
            {
                d.ngayLam = ct.ngayLam;
                d.gioBatDau = ct.gioBatDau;
                d.gioKetThuc = ct.gioKetThuc;
                d.soLuong = ct.soLuong;
                d.trangThai = ct.trangThai;
            }
            db.SaveChanges();
        }
        public void Delete(string mact)
        {
            QLNH_DB db = new QLNH_DB();
            var ct = db.CHITIETCALAMs.Where(p => p.maCT == mact).FirstOrDefault();
            if(ct != null) { 
                db.CHITIETCALAMs.Remove(ct);
                db.SaveChanges();
                MessageBox.Show("Xóa thành công!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Không tìm thấy tài khoản cần xóa!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
