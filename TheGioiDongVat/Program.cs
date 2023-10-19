using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGioiDongVat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            SERVICE sERVICE = new SERVICE();
            sERVICE.AddDataDemo();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Chon chuc nang:");
                Console.WriteLine("1. Nhap danh sach");
                Console.WriteLine("2. Xuat danh sach");
                Console.WriteLine("3. Xuat Dong vat ten chua chu A");
                Console.WriteLine("4. Sap xep theo ID Giam dan");
                Console.WriteLine("5. Thoat");
                Console.WriteLine("6. Ke Thua");
                string cn = Console.ReadLine();
                if(cn == "5")
                {
                    break;
                }
                switch (cn)
                {
                    case "1":
                        {
                            sERVICE.CN1AddDongVat();
                            break;
                        }
                    case "2":
                        {
                            sERVICE.CN2XuatDuLieu();
                            break;
                        }
                    case "3":
                        {
                            sERVICE.CN3XuatTenChuaA();
                            break;
                        }
                    case "4":
                        {
                            sERVICE.CN4SortByID();
                            break;
                        }
                    case "6":
                        {
                            sERVICE.CN6KeThua();
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Chuc nang khong ton tai");
                            break;
                        }
                }

                Console.WriteLine("Press a button to continue");
                Console.ReadLine();
            }
        }
    }

}
