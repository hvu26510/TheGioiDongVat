using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGioiDongVat
{
    public class DongVat : IComparable<DongVat>
    {
        private int ID;
        private string Ten;
        private string NoiSong;

        public DongVat()
        {
        }

        public DongVat(int iD, string ten, string noiSong)
        {
            ID = iD;
            Ten = ten;
            NoiSong = noiSong;
        }
        public string getTen()
        {
            return this.Ten;
        }
        public string getNoiSong()
        {
            return this.NoiSong;
        }
        public int getID()
        {
            return this.ID;
        }
        public void NhapThongTin()
        {
            Console.WriteLine("ID:");
            ID = int.Parse(Console.ReadLine());
            Console.WriteLine("Ten:");
            Ten = Console.ReadLine();
            Console.WriteLine("Noi Song:");
            NoiSong = Console.ReadLine();
        }

        public virtual void InThongTin()
        {
            Console.WriteLine($"ID: {ID}, Ten:{Ten}, NoiSong:{NoiSong}");
        }

        public int CompareTo(DongVat other)
        {
            return this.ID.CompareTo(other.ID);
        }
    }

    public class DongVatAnThit : DongVat
    {
        int SoRang;

        public DongVatAnThit()
        {
        }

        public DongVatAnThit(int iD, string ten, string noiSong, int soRang) : base(iD, ten, noiSong)
        {
            this.SoRang = soRang;
        }

        public void NhapThongTin()
        {
            base.NhapThongTin();
            Console.WriteLine("So rang:");
            SoRang = int.Parse(Console.ReadLine());
        }
        public override void InThongTin()
        {
            Console.WriteLine($"ID: {base.getID()}, Ten:{base.getTen()}, NoiSong:{base.getNoiSong()}, So rang: {SoRang}");
        }
    }
}
