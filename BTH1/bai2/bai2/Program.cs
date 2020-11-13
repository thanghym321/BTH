using System;

namespace bai2
{
    class Employee
    {
        private int id, yearOFBirth;
        private string name;
        private double salaryLevel, basicSalary;

        public int getid
        {
            get
            {
                return id;
            }
        }
        public string getname
        {
            get
            {
                return name;
            }
        }
        public int getyearofbirth
        {
            get
            {
                return yearOFBirth;
            }
        }
        public double getincome
        {
            get
            {
                return salaryLevel * basicSalary;
            }
        }
        public void display()
        {
            Console.Write("dinh danh:{0}+\n+ten:{1}+\n+nam sinh:{2}+\n+luong co ban:{3}+\n+thu nhap:{4}", id, name, yearOFBirth, basicSalary, getincome);
        }
        public double setsalarylevel
        {
            set
            {
                salaryLevel = value;
            }
        }
        public double setbasicsalary
        {
            set
            {
                basicSalary = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
