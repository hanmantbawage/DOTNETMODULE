using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign01_Emp
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee o1 = new Employee();
            Employee o2 = new Employee();
            Employee o3 = new Employee();

            Console.WriteLine(o1.EMPNO);
            Console.WriteLine(o2.EMPNO);
            Console.WriteLine(o3.EMPNO);


            Console.WriteLine(o3.EMPNO);
            Console.WriteLine(o2.EMPNO);
            Console.WriteLine(o1.EMPNO);
            Console.ReadLine();
        }
    }
    class Employee
    {
        string Name = "";
        static int E=0;
        int EmpNo;
        decimal Basic;
        short DeptNo;
        double Salary;
        #region constructor
        
        public Employee(string s="NO Name", int no=10000, short dno=5)
        {
            E = E + 1;
            EmpNo = E;
            Name = s;
            Basic = no;
            DeptNo = dno;
        }
        #endregion


        public String NAME
        {
            set
            {
                if (value == "")
                {
                    Console.WriteLine("Invalid Data..!!!!!!!");
                }
                else
                {
                    Name = value;
                   
                }
            }
            get
            {
                return Name;
            }
        }

        public  int EMPNO
        
        {
           
            get
            {
                return EmpNo;
            }
        }
        public Double SALARY
        {
            set
            {

                if (value > 15000 )
                {
                    Salary = (Double)value * 1.35;

                }
                else 
                {
                    Salary = (Double)value * 1.50;

                }
            }
            get
            {
                return Salary;
            }
        }

        public short DEPTNO
        {
            set
            {
                if (value > 0)
                {
                    DeptNo = value;
                }
                else
                {
                    Console.WriteLine("Invalid DeptNO..!!!!!!!");
                }
            }

        }
    }
}
