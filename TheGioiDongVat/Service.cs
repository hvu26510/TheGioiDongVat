using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGioiDongVat
{
    public class SERVICE
    {
        List<DongVat> dongVatList= new List<DongVat>();

        public void AddDataDemo()
        {
            DongVat dv1 = new DongVat(1,"Ca heo", "Bien ca");
            DongVat dv2 = new DongVat(2, "KHA LUNG", "Dong Co");
            DongVat dv3 = new DongVat(3, "CAPYPARA", "Nam My");
            dongVatList.Add(dv1);
            dongVatList.Add(dv2);
            dongVatList.Add(dv3);
        }

        public void CN1AddDongVat()
        {
            while(true)
            {
                DongVat dv = new DongVat();
                dv.NhapThongTin();
                dongVatList.Add(dv);

                Console.WriteLine("Tiep tuc? Y");
                string con = Console.ReadLine();
                if(con.ToUpper() != "Y")
                {
                    break;
                }
            }
        }

        public void CN2XuatDuLieu()
        {
            foreach(DongVat dv in dongVatList)
            {
                dv.InThongTin();
            }
        }

        public void CN3XuatTenChuaA()
        {
            foreach (DongVat dv in dongVatList)
            {
                string tenDV = dv.getTen(); // lay ra ten DV

                if (tenDV.Contains("A")) // kiem tra neu tenDV co chua "A" thi tra ve true
                {
                    dv.InThongTin();
                }
            }
        }

        public void CN4SortByID()
        {
            //Cach 1
            //dongVatList.Sort((x,y)=> y.getID().CompareTo(x.getID()));

            //Cach 2
            dongVatList.Sort();
            dongVatList.Reverse();

            CN2XuatDuLieu();
        }
        public void CN6KeThua()
        {
            DongVatAnThit dvat = new DongVatAnThit(); //tao doi tuong contructor khong tham so
            dvat.NhapThongTin();
            dvat.InThongTin();
        }
    }
}
