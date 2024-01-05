using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap05
{
    class CD
    {
        private int macd, sobaihat;
        private int dongia;
        private string casi, tuacd;
        public CD()
        {

        }
        public CD(int macd)
        {
            this.macd = macd;
        }
        public CD(int MacD, int SoBaiHat,int dongia, string casi, string tuacd)
        {
            this.Macd = macd;
            this.SoBaiHat = SoBaiHat;
            this.dongia= dongia;
            this.tuacd = tuacd;
            this.casi = casi;
        }
        public int Macd
        {
            set { this.macd = value; }
            get { return macd; }
        }
        public int SoBaiHat
        {
            set { this.sobaihat = value; }
            get { return sobaihat; }
        }
        public int Dongia
        {
            set { this.dongia = value; }
            get { return dongia; }
        }
        public string Tuacd
        {
            set { this.tuacd = value; }
            get { return tuacd; }
        }
        public string Casi
        {
            set { this.casi = value; }
            get { return casi; }

        }
        public string ToString()
        {
            return string.Format("{0,10}", "{1,20}", "{2,30}", "{3,15:#,##0}", macd, tuacd, casi, sobaihat, dongia);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            menu();
        }
        static void menu()
        {
            QuanLyCD quanLyCD = new QuanLyCD();
            int luachon = 0;
            do
            {
                Console.WriteLine("***************CHUONG TRINH QUAN LY CD*******************");
                Console.WriteLine("1.ThemCD");
                Console.WriteLine("2.Tinh Gia Trung Binh");
                Console.WriteLine("3.Sap Xep CD Giam Dan Theo Gia Thanh");
                Console.WriteLine("4.Sap Xep Tua Giam Dan theo tua CD");
                Console.WriteLine("5.Xuat Toan Bo CD");
                Console.WriteLine("0.Thoat chuong trinh:");
                Console.WriteLine("*********************************************************");
                Console.Write("Ban Chon:");
                luachon = int.Parse(Console.ReadLine());
                switch (luachon)
                {
                    case 1:
                        CD cD = new CD();
                        Console.WriteLine("Nhập ma CD:");
                        cD.Macd = int.Parse(Console.ReadLine());
                        Console.WriteLine("Nhập tua cd:");
                        cD.Tuacd =Console.ReadLine();
                        Console.WriteLine("Nhập tên Ca Sĩ:");
                        cD.Casi = Console.ReadLine();
                        Console.WriteLine("Nhập S Bài Hát:");
                        cD.SoBaiHat =int.Parse(Console.ReadLine());
                        Console.WriteLine("Nhập Đơn Gía:");
                        cD.Macd = int.Parse(Console.ReadLine());
                        quanLyCD.themCD(cD);
                        break;
                    case 2:
                        double kq = quanLyCD.tinhGiaTB();
                        Console.WriteLine("Gia Thanh Trung Binh:Ơ0;#,##0.00}", kq);
                        break;
                    case 3:
                        quanLyCD.SapXepGiamTheoGiaThanh();
                        Console.WriteLine("Da sap xep theo gia thanh giam dan");
                        break;
                    case 4:
                        break;
                    case 5:
                        quanLyCD.Xuat();
                        break;
                    case 0:
                        Console.WriteLine("Tam Biet. Hen gap lai");
                        Console.ReadLine();
                        break;
                }

            } while (luachon != 0);
            }
    }
}
