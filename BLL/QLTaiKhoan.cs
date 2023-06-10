using DoAnPBL3.DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DoAnPBL3.BLL
{
    public class QLTaiKhoan
    {
        public static QLTaiKhoan Instance = new QLTaiKhoan();
        public string TenDangNhap { get; set; }


        public void Login(string tendangnhap, string matkhau, bool vaitro)
        {
            QLNH_DB db = new QLNH_DB();
            string mahoa = Convert_Password.Encode(matkhau);
            var user = db.TAIKHOANs.Where(p => p.tenDangNhap == tendangnhap && p.matKhau == mahoa && p.vaiTro == vaitro && p.coXoa == false).FirstOrDefault();
            if (user == null)
            {
                MessageBox.Show("Đăng nhập thất bại! \nTên đăng nhập hoặc mật khẩu chưa đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                TenDangNhap = tendangnhap;
                switch (vaitro)
                {
                    case false:
                        new UINhaHangNhanVien().ShowDialog();
                        break;
                    case true:
                        new UINhahangAdmin().ShowDialog();
                        break;
                }
            }
        }


        public NHANVIEN GetUserByUserName()
        {
            QLNH_DB db = new QLNH_DB();
            var NV = db.NHANVIENs.Where(p => p.SDT == TenDangNhap).FirstOrDefault();
            return NV;
        }

        public void UpdateInfoAccount(string maTK, string tenDN, string tenNV, string diaChi)
        {
            QLNH_DB db = new QLNH_DB();
            TAIKHOAN taiKhoan = db.TAIKHOANs.Find(maTK);
            taiKhoan.tenDangNhap = tenDN;

            var nv = db.NHANVIENs.Where(p => p.maTK == maTK).FirstOrDefault();
            nv.tenNV = tenNV;
            nv.SDT = tenDN;
            nv.diaChi = diaChi;
            db.SaveChanges();
        }

        public bool CheckChangePassword(string matkhaucu, string matkhaumoi, string matkhauxacnhan)
        {
            if (matkhaucu == "" || matkhaumoi == ""|| matkhauxacnhan == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (matkhauxacnhan != matkhaumoi)
            {
                MessageBox.Show("Mật khẩu xác nhận không trùng khớp! Vui lòng nhập lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            QLNH_DB db = new QLNH_DB();
            var user = db.TAIKHOANs.FirstOrDefault(p => p.tenDangNhap == TenDangNhap);
            if (user.matKhau != Convert_Password.Encode(matkhaucu))
            {
                MessageBox.Show("Mật khẩu cũ không chính xác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }


        public bool SetPassWord(string matkhaucu, string matkhaumoi, string matkhauxacnhan)
        {
            QLNH_DB db = new QLNH_DB();
            if (CheckChangePassword(matkhaucu, matkhaumoi, matkhauxacnhan))
            {
                var taiKhoan = db.TAIKHOANs.Where(p => p.tenDangNhap == TenDangNhap).FirstOrDefault();
                taiKhoan.matKhau = Convert_Password.Encode(matkhaumoi);
                db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<TAIKHOAN> GetAllAccount(string tendangnhap)
        {
            QLNH_DB db = new QLNH_DB();
                var list = db.TAIKHOANs.Where(p => p.tenDangNhap.Contains(tendangnhap) && p.coXoa == false).ToList();
                return list;
        }
        public bool CheckForgotPassword(string tendangnhap, string kytu, string matkhaumoi, string matkhauxacnhan)
        {
            if (string.IsNullOrEmpty(tendangnhap) || string.IsNullOrEmpty(matkhaumoi) || string.IsNullOrEmpty(kytu) || string.IsNullOrEmpty(matkhauxacnhan))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (matkhauxacnhan != matkhaumoi)
            {
                MessageBox.Show("Mật khẩu xác nhận không trùng khớp với mật khẩu mới! Vui lòng nhập lại", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            QLNH_DB db = new QLNH_DB();
            var user = db.TAIKHOANs.Where(p => p.tenDangNhap == tendangnhap).FirstOrDefault();
            if (user == null)
            {
                MessageBox.Show("Tài khoản không tồn tại!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else
            {
                if (user.kyTu != kytu)
                {
                    MessageBox.Show("Ký tự đặc biệt không chính xác!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
            }


            return true;
        }
        public bool ForgotPassword(string tendangnhap, string kytu, string matkhaumoi, string matkhauxacnhan)
        {
            QLNH_DB db = new QLNH_DB();
            if (CheckForgotPassword(tendangnhap, kytu, matkhaumoi, matkhauxacnhan))
            {
                var taiKhoan = db.TAIKHOANs.Where(p => p.tenDangNhap == tendangnhap && p.kyTu == kytu).FirstOrDefault();
                taiKhoan.matKhau = Convert_Password.Encode(matkhaumoi);
                db.SaveChanges();
                return true;
            }
            return false;
        }
        public void Add(TAIKHOAN tk)
        {
            QLNH_DB db = new QLNH_DB();
            string lastID = db.TAIKHOANs.OrderByDescending(p => p.maTK).Select(p => p.maTK).FirstOrDefault();
            string nextID = "";
            int num = int.Parse(lastID.Replace("TK", ""));
            num++;
            nextID = "TK" + num.ToString("D3");
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

            NHANVIEN nv = db.NHANVIENs.Where(p => p.maTK == tk.maTK).FirstOrDefault();
            nv.SDT = tk.tenDangNhap;

            db.SaveChanges();
        }

        public void Delete(string matk)
        {
            QLNH_DB db = new QLNH_DB();
            var tk = db.TAIKHOANs.Find(matk);
            tk.coXoa = true;

            var nv = db.NHANVIENs.Where(p => p.maTK == tk.maTK).FirstOrDefault();
            if (nv != null)
            {
                nv.coXoa = true;
            }
            else return;
            db.SaveChanges();
        }
    }
}





