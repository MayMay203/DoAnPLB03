using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnPBL3.BLL
{
    public class QLHDBLL
    {
        private static QLHDBLL _Instance;
        public static QLHDBLL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new QLHDBLL();
                }
                return _Instance;
            }
            private set { _Instance = value; }
        }

        //public List<HoaDon> GetAll_HoaDon()
        //{

        //}
    }
}
