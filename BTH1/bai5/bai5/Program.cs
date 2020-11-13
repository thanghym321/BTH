using System;

namespace bai5
{
    class Matran
    {
        private int sh, sc;
        private int[,] a;
        public Matran()
        {
            sh = sc = 0;
            a = new int[sh, sc];
        }
        public Matran(int sh, int sc)
        {
            this.sh = sh;
            this.sc = sc;
            a = new int[sh, sc];
        }
        public Matran(Matran t2)
        {
            this.sh = t2.sh;
            this.sc = t2.sc;
            this.a = new int[sh, sc];
            for (int i = 0; i < sh; i++)
                for (int j = 0; j < sc; j++)
                    this.a[i, j] = t2.a[i, j];
        }
        public void print()
        {
            for (int i = 0; i < sh; i++)
            {
                for (int j = 0; j < sc; j++)
                    Console.Write("{0}\t", a[i, j]);
                Console.WriteLine();
            }
        }
        public void Nhap()
        {
            for (int i = 0; i < sh; i++)
                for (int j = 0; j < sc; j++)
                {
                    Console.Write("a[{0},{1}]=", i, j);
                    a[i, j] = int.Parse(Console.ReadLine());
                }
        }
        public Matran Tong(Matran t2)
        {
            if (this.sh == t2.sh && this.sc == t2.sc)
            {
                Matran t = new Matran(this.sh, this.sc);
                for (int i = 0; i < sh; i++)
                    for (int j = 0; j < sc; j++)
                        t.a[i, j] = this.a[i, j] + t2.a[i, j];
                return t;
            }
            else return null;
        }
        public Matran Hieu(Matran t2)
        {
            if (this.sh == t2.sh && this.sc == t2.sc)
            {
                Matran t1 = new Matran(this.sh, this.sc);
                for (int i = 0; i < sh; i++)
                    for (int j = 0; j < sc; j++)
                        t1.a[i, j] = this.a[i, j] - t2.a[i, j];
                return t1;
            }
            else return null;
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            Matran a = new Matran(2, 3);
            Console.WriteLine("Nhap ma tran thu 1:"); a.Nhap();
            Matran b = new Matran(a);
            Console.WriteLine("Nhap ma tran thu 2:");
            b.Nhap();
            Console.WriteLine("Ma tran thu 1"); a.print();
            Console.WriteLine("Ma tran thu 2"); b.print();
            Matran c = a.Tong(b);
            if (c == null) Console.WriteLine(" Hai ma  tran co kich thuoc khac nhau");
            else
            {
                Console.WriteLine("Ma tran tong"); c.print();
            }
            Matran d = a.Hieu(b);
            if (d == null) Console.WriteLine(" Hai ma  tran co kich thuoc khac nhau");
            else
            {
                Console.WriteLine("Ma tran hieu"); d.print();
            }

            Console.ReadKey();
        }
    }
}
