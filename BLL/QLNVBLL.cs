using DoAnPBL3.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnPBL3.BLL
{
    class QLNVBLL
    {
        private static QLNVBLL _Instance;

        public static QLNVBLL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new QLNVBLL();
                }
                return _Instance;
            }
            private set { _Instance = value; }
        }

        public List<NHANVIEN> GetAll_NV(string txt)
        {
            QLNH_DB db = new QLNH_DB();
            if (txt == null)
            {
                var list = db.NHANVIENs.Where(p => p.coXoa == false).Select(p => p).ToList();
                return list;
            }
            else
            {
                var list = db.NHANVIENs.Where(p => p.tenNV.Contains(txt) && p.coXoa == false).ToList();
                return list;
            }

        }
        public void Add(NHANVIEN nv)
        {
            QLNH_DB db = new QLNH_DB();
            string lastID = db.NHANVIENs
                              .Where(p => p.maNV.StartsWith("NV"))
                              .OrderByDescending(p => p.maNV)
                              .Select(p => p.maNV)
                              .FirstOrDefault();
            string nextID = "";
            if (lastID != "")
            {
                int num = int.Parse(lastID.Replace("NV", ""));
                num++;
                nextID = "NV" + num.ToString("D3");
            }
            nv.maNV = nextID;
            db.NHANVIENs.Add(nv);
            db.SaveChanges();
            //QLNH_DB db = new QLNH_DB();
            //string lastID = db.NHANVIENs.OrderByDescending(p => p.maNV).Select(p => p.maNV).FirstOrDefault();
            //string nextID = "";
            //if (lastID != "")
            //{
            //    int num = int.Parse(lastID.Replace("NV", ""));
            //    num++;
            //    nextID = "NV" + num.ToString("D3");
            //}
            //nv.maNV = nextID;
            //db.NHANVIENs.Add(nv);
            //db.SaveChanges();   
        }
        public void Update(NHANVIEN nv)
        {
            QLNH_DB db = new QLNH_DB();
            NHANVIEN t = db.NHANVIENs.Find(nv.maNV);
            if(t != null)
            {
                t.maTK = nv.maTK;
                t.tenNV = nv.tenNV;
                t.ngaySinh = nv.ngaySinh;
                t.SDT = nv.SDT;
                t.gioiTinh = nv.gioiTinh;
                t.diaChi = nv.diaChi;
                t.CCCD = nv.CCCD;
                t.luong = nv.luong;
                t.coXoa = nv.coXoa;
                db.SaveChanges();
            }
        }

    }
}
