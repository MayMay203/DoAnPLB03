using DoAnPBL3.DTO;
using DoAnPBL3.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DoAnPBL3.BLL
{
    public class QLBanAn
    {
        public static QLBanAn Instance = new QLBanAn();

        public List<BANAN> GetAllBABy(string trangThai, string soGhe)
        {
            QLNH_DB db = new QLNH_DB();
            int SG;
            if (trangThai == "Tất cả" && soGhe != "")
            {
                try
                {
                    SG = Convert.ToInt32(soGhe);
                    var list = db.BANANs
                               .Where(p => p.soGhe == SG && p.coXoa == false).ToList();
                    return list;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Thông tin không hợp lệ.\nVui lòng kiểm tra lại!", "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
                    return null;
                }
            }
            else if (trangThai == "Tất cả" && soGhe == "")
            {
                var list = db.BANANs.Where(p => p.coXoa == false).Select(p => p).ToList();
                return list;
            }
            else if (soGhe == "")
            {
                var list = db.BANANs.Where(p => p.trangThai == trangThai && p.coXoa == false).ToList();
                return list;
            }
            else
            {
                try
                {
                    SG = Convert.ToInt32(soGhe);
                    var list = db.BANANs.Where(p => p.trangThai == trangThai && p.soGhe == SG && p.coXoa == false).ToList();
                    return list;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Thông tin không hợp lệ.\nVui lòng kiểm tra lại!", "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
                    return null;
                }
            }
        }

        public BANAN GetBAByMaBan(string MaBan)
        {
            QLNH_DB db = new QLNH_DB();
            BANAN ba = db.BANANs.Where(p => p.maBan == MaBan).FirstOrDefault();
            return ba;
        }

        public void Add(BANAN ba)
        {
            QLNH_DB db = new QLNH_DB();
            string lastID = db.BANANs.OrderByDescending(p => p.maBan)
                                     .Select(p => p.maBan)
                                     .FirstOrDefault();
            string nextID = "";
            int num = int.Parse(lastID.Replace("MB", ""));
            num++;
            nextID = "MB" + num.ToString("D3");
            ba.maBan = nextID;
            db.BANANs.Add(ba);
            db.SaveChanges();
        }

        public void Update(BANAN ba)
        {
            QLNH_DB db = new QLNH_DB();
            BANAN ban = db.BANANs.Find(ba.maBan);
            ban.soGhe = ba.soGhe;
            ban.ghiChu = ba.ghiChu;
            db.SaveChanges();
        }

        public void Delete(string maBan)
        {
            QLNH_DB db = new QLNH_DB();
            BANAN ba = db.BANANs.Find(maBan);
            ba.coXoa = true;
            db.SaveChanges();
        }
    }
}
