using System;

namespace bai4
{
    class ComplexNumber
    {
        private double thuc, ao;
        public ComplexNumber()
        {
            thuc = 0;
            ao = 0;
        }
        public ComplexNumber(double thuc,double ao)
        {
            this.thuc = thuc;
            this.ao = ao;
        }
        public ComplexNumber(ComplexNumber t2)
        {
            this.thuc = t2.thuc;
            this.ao = t2.ao;
        }
        public void Hien()
        {
            Console.WriteLine("So phuc: z={0}+{1}*i", thuc, ao);
        }
        public ComplexNumber Tong(ComplexNumber t2)
        {
            ComplexNumber t = new ComplexNumber();
            t.thuc = this.thuc + t2.thuc;
            t.ao = this.ao + t2.ao;
            return t;
        }
        public ComplexNumber Hieu(ComplexNumber t2)
        {
            ComplexNumber t1 = new ComplexNumber();
            t1.thuc = this.thuc - t2.thuc;
            t1.ao = this.ao - t2.ao;
            return t1;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            ComplexNumber a = new ComplexNumber(2, 5);
            ComplexNumber b = new ComplexNumber(3, 6);
            Console.WriteLine("So phuc thu nhat"); a.Hien();
            Console.WriteLine("So phuc thu hai"); b.Hien();
            ComplexNumber c = a.Tong(b);
            Console.WriteLine("Tong hai so phuc: "); c.Hien();
            ComplexNumber d = a.Hieu(b);
            Console.WriteLine("Hieu hai so phuc: "); d.Hien();

            Console.ReadKey();
        }
    }
}
