using System;

namespace BTH1
{
    class Diem
    {
        private double x, y;

        public Diem()
        {
            x = y = 0;
        }
        public Diem(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public void Nhap()
        {
            Console.Write("Nhap x= "); x = double.Parse(Console.ReadLine());
            Console.Write("Nhap y= "); y = double.Parse(Console.ReadLine());
        }
        public void HienThi()
        {
            Console.WriteLine("Toa do (x,y) = ({0},{1})", x, y);
        }
        public double KhoangCach(Diem a, Diem b)
        {
            return Math.Sqrt(Math.Pow(a.x - b.x, 2) + Math.Pow(a.y - b.y, 2));
        }
    }
    class Bai1
    {
        static void Main(string[] args)
        {
            Diem a = new Diem();
            Diem b = new Diem();
            a.Nhap();
            b.Nhap();
            a.HienThi();
            b.HienThi();
            double kc = a.KhoangCach(a, b);
            Console.WriteLine("Khoang cach cua hai diem la: {0}", kc);

            Console.ReadKey();
        }
    }
}
