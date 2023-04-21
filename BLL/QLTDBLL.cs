using DoAnPBL3.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnPBL3.BLL
{
    public class QLTDBLL
    {
        public static QLTDBLL Instance = new QLTDBLL();

        public List<string> GetAllTLM()
        {
            QLNH_DB db = new QLNH_DB();
            var list = db.LOAIMONs.Select(p => p.tenLM).ToList();
            return list;
        }
        public List<MONAN> GetAllMABy(string tenLM)
        {
            QLNH_DB db = new QLNH_DB();
            if (tenLM == "Tất cả")
            {
                var list1 = db.MONANs.Select(p => p).ToList();
                return list1;
            }
            var list2 = db.MONANs.Where(p => p.LOAIMON.tenLM.ToUpper() == tenLM.ToUpper()).ToList();
            return list2;
        }

        public string GetMaLMByTLM(string tenLM)
        {
            QLNH_DB db = new QLNH_DB();
            string maLM = db.LOAIMONs.Where(p=>p.tenLM == tenLM).Select(p=>p.maLM).ToString();
            return maLM;
        }

        public string GetTLMByMaLM(string maLM)
        {
            QLNH_DB db = new QLNH_DB();
            string tenLM = db.LOAIMONs.Where(p => p.maLM == maLM).Select(p => p.tenLM).ToString();
            return tenLM;
        }

        public void Add(MONAN monan)
        {
            QLNH_DB db = new QLNH_DB();
            string lastID = db.MONANs.OrderByDescending(a => a.maMA).Select(p => p.maMA).FirstOrDefault();
            string nextID = "";
            if (lastID != "")
            {
                int num = int.Parse(lastID.Replace("MA",""));
                num++;
                nextID = "MA" + num.ToString("D3");
            }
            monan.maMA = nextID;
            db.MONANs.Add(monan);
            db.SaveChanges();
        }

        public void Update(MONAN monan)
        {
            QLNH_DB db = new QLNH_DB();
            MONAN ma = db.MONANs.Find(monan.maMA);
                ma.tenMA = monan.tenMA;
                ma.donViTinh = monan.donViTinh;
                ma.maLM = monan.maLM;
                ma.GiaMA = monan.GiaMA;
                db.SaveChanges();
        }

        public void Delete(string id)
        {
            //QLNH_DB db = new QLNH_DB();
            //MONAN ma = db.MONANs.Find(id);
            //db.MONANs.Remove(ma);
            //db.SaveChanges();
        }




    }
}
