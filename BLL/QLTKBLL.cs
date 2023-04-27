using DoAnPBL3.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;


namespace DoAnPBL3.BLL
{
    public class QLTKBLL
    {
        private static QLTKBLL _Instance;
        public string Tendangnhap { get; set; }

        public static QLTKBLL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new QLTKBLL();
                }
                return _Instance;
            }
            private set { _Instance = value; }
        }
        bool CheckDN(string tendangnhap, string matkau, bool vaitro)
        {
            if(string.IsNullOrEmpty(tendangnhap) || string.IsNullOrEmpty(matkau))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tên đăng nhập và mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if(!vaitro)
            {
                MessageBox.Show("Vui lòng chọn quyền đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }
        public void DangNhap(string tendangnhap, string matkhau, bool vaitro)
        {
            if (CheckDN(tendangnhap, matkhau, vaitro))
            {
                QLNH_DB db = new QLNH_DB();
                var user = db.TAIKHOANs.Where(p => p.tenDangNhap == tendangnhap && p.matKhau == matkhau && p.vaiTro == vaitro).FirstOrDefault();
                if (user == null)
                {
                    MessageBox.Show("Đăng nhập thất bại! Vui lòng nhập đúng tên đăng nhập hoặc mật khẩu", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Tendangnhap = tendangnhap;
                    switch (vaitro)
                    {
                        case false:
                            new UINhahangNhanVien().ShowDialog();
                            break;
                        case true:
                            new UINhahangAdmin().ShowDialog();
                            break;
                    }

                }
            }
            else return;      
        }
        public NHANVIEN GetUserByTDN()
        {
            QLNH_DB db = new QLNH_DB();
            var nv = db.NHANVIENs.Where(p => p.SDT == Tendangnhap).FirstOrDefault();
            return nv;
        }
        public void UpdateThongtintaikhoan(string matk, string tendangnhap, string tennguoidung, string diachi)
        {
            QLNH_DB db = new QLNH_DB();
            var user = db.TAIKHOANs.Where(p => p.tenDangNhap == Tendangnhap).FirstOrDefault();
            user.maTK = matk;

            var nv = db.NHANVIENs.Where(p => p.maTK == matk).FirstOrDefault();
            nv.SDT = tendangnhap;
            nv.tenNV = tennguoidung;
            nv.diaChi = diachi;
            
            db.SaveChanges();
            MessageBox.Show("Cập nhật thành công!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        public bool CheckDoiMK(string matkhaucu, string matkhaumoi, string xacnhanmatkhau)
        {
            if (string.IsNullOrEmpty(matkhaucu) || string.IsNullOrEmpty(matkhaumoi) || string.IsNullOrEmpty(xacnhanmatkhau))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin mật khẩu!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (xacnhanmatkhau != matkhaumoi)
            {
                MessageBox.Show("Mật khẩu xác nhận không trùng khớp với mật khẩu mới! Vui lòng nhập lại", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }


            QLNH_DB db = new QLNH_DB();
            var user = db.TAIKHOANs.Where(p => p.tenDangNhap == Tendangnhap).FirstOrDefault();
            if (user == null)
            {
                MessageBox.Show("Tài khoản không tồn tại", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else
            {
                if (user.matKhau != matkhaucu)
                {
                    MessageBox.Show("Mật khẩu cũ không chính xác!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
            }
            return true;
        }
        public void Doimatkhau(string matkhaucu, string matkhaumoi, string xacnhanmatkhau)
        {
            if (CheckDoiMK(matkhaucu, matkhaumoi, xacnhanmatkhau))
            {
                QLNH_DB db = new QLNH_DB();
                var user = db.TAIKHOANs.Where(p => p.tenDangNhap == Tendangnhap).FirstOrDefault();
                user.matKhau = matkhaumoi;
                db.SaveChanges();
                MessageBox.Show("Đổi mật khẩu thành công!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        public List<TAIKHOAN> GetAll_TaiKhoan(string tentaikhoan)
        {

            QLNH_DB db = new QLNH_DB();
            if (string.IsNullOrEmpty(tentaikhoan))
            {
                var list = db.TAIKHOANs.Where(p => p.coXoa == false).Select(p => p).ToList();
                return list;
            }
            else
            {
                var list = db.TAIKHOANs.Where(p => p.tenDangNhap.Contains(tentaikhoan) && p.coXoa == false).ToList();
                return list;
            }
        }
        public void Add(TAIKHOAN tk)
        {
            QLNH_DB db = new QLNH_DB();
            string lastID = db.TAIKHOANs.OrderByDescending(p => p.maTK).Select(p => p.maTK).FirstOrDefault();
            string nextID = "";
            if (lastID != "")
            {
                int num = int.Parse(lastID.Replace("TK", ""));
                num++;
                nextID = "TK" + num.ToString("D3");
            }
            tk.maTK = nextID;
            db.TAIKHOANs.Add(tk);
            db.SaveChanges();
        }
        public void Update(TAIKHOAN tk)
        {
            QLNH_DB db = new QLNH_DB();
            TAIKHOAN t = db.TAIKHOANs.Find(tk.maTK);

            t.tenDangNhap = tk.tenDangNhap;
            t.matKhau = tk.matKhau;
            t.vaiTro = tk.vaiTro;
            db.SaveChanges();
        }
        public void Delete(string matk)
        {
            
            QLNH_DB db = new QLNH_DB();
            var tk = db.TAIKHOANs.Where(p => p.maTK == matk).FirstOrDefault();
            if (tk != null)
            {
                //db.TAIKHOANs.Remove(tk);
                tk.coXoa = true;
                var nv = db.NHANVIENs.Where(p => p.maTK == tk.maTK).FirstOrDefault();
                nv.coXoa = true;
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
