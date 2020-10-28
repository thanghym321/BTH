using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baithuchanhso1
{
    class Employee
    {
        private int id;
        private string name;
        private int yearOfBirth;
        private double salaryLevel, basicSalary;
        public int getid
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }

        }
        public string getName
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public int getYearOfBirth
        {
            get
            {
                return yearOfBirth;
            }
        }

        public double getIncome(double salaryLevel, double basicSalary)
        {

            return salaryLevel * basicSalary;
        }
        public void display()
        {
            Console.WriteLine("Dinhdanh:{0}\nTen:{1}\nnamsinh:{2}\nluongcoban:{3}\nthunhap:{4}", id, name, yearOfBirth, salaryLevel, basicSalary);
        }
        public double setSalaryLevel
        {
            set
            {
                salaryLevel = value;
            }
        }
        public double setBasicSalary
        {
            set
            {
                basicSalary = value;
            }
        }
    }

}