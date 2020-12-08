using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    class Program
    {
        static void Main    (string[] args)
        {
            Func<decimal, decimal, decimal, decimal> si = (P, N, R) => P * N * (R / 100);
            Console.WriteLine(si(10000, 1, 6));

            Func<int, int, bool> s1 = (x, y) => x > y ? true : false;
            Console.WriteLine(s1(45, 47));
           
            Employee e1 = new Employee("hanmant", 5000);
            Func<Employee, int> e2 = x => x.Basic;
            Console.WriteLine(e2(e1));

            Func<Employee, bool> e3 = x => x.Basic>10000?true:false;
            Console.WriteLine(e3(e1));
          

            Func<int, bool> r = r1 => (r1 % 2) == 0 ? true : false;
            Console.WriteLine(r(11));

            Console.ReadLine();
        }
      public class Employee
        {
            private String ename;
            private int basic;
            public Employee(string ename,int basic)
            {
                this.ename = ename;
                this.basic = basic;

            }
            public String Ename
            {
                set
                {
                    ename = value;
                }
                get
                {
                    return ename;
                }
            }
            public int Basic 
            {
                set
                {
                    basic = value;
                }
                get
                {
                    return basic;
                }
            }


        }
    }
}
