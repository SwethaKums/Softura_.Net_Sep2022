using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konsole
{
    internal class Task5Employee
    {
public static void Main()
        {
            Sales sales = new Sales();
            sales.EmployeeName("swetha","sales");
            sales.EmployeeId("S001");
            sales.Gender("female");
            sales.YearOfExperience(1);
            sales.Salary(20000);
            sales.calculation2(20000);
            Marketing mark=new Marketing();
            mark.EmployeeName("kumar","marketing");
            mark.EmployeeId("M002");
            mark.Gender("male");
            mark.YearOfExperience(2);
            mark.Salary(40000);
             mark.calculation(40000);
            Production pro = new Production();
            pro.EmployeeName("arjun","production");
            pro.EmployeeId("P002");
            pro.Gender("male");
            pro.YearOfExperience(3);
            pro.Salary(50000);
            pro.calculation1(50000);
            


        }
    }
    abstract class Details
    {
        abstract public void EmployeeId(String id);
        abstract public void EmployeeName(string name,string deptname);
        abstract public void Gender(string gender);
        abstract public void YearOfExperience(int year);
        abstract public void Salary(int salary);

 } 
    class Sales:Details
    {
       
        public void calculation2(int Salary)

        {
            double bonus = Salary*0.2;


            Console.WriteLine("the bonus is{0}", bonus);

            Console.WriteLine("the total salary of sales dept employe is{0}", bonus+Salary);
        }
        public override void EmployeeId(string id)
        {
            Console.WriteLine("the employee id is{0}",id);
        }
        public override void EmployeeName(String name ,string deptname )
        {
            Console.WriteLine("the employee name is{0} from {1}", name,deptname);
        }

        public override void Gender(String gender)
        {
            Console.WriteLine("the employee name is{0}", gender);
        }
        public override void YearOfExperience(int year)
        {
            Console.WriteLine("the employee name is{0}", year);
        }
        public override void Salary(int salary)
        {
            Console.WriteLine("the employee name is{0}", salary);
        }
    }
    class Marketing:Sales
    {
        
        public void calculation(int Salary)

        {
            double bonus = Salary*0.2;
            Console.WriteLine("the bonus is{0}", bonus);
            Console.WriteLine("the total salary of marketing employee is {0}",bonus+Salary);
        }
    }
    class Production : Sales
    {
        
             public void calculation1(int Salary)
        {
            double bonus = Salary*0.1;
            Console.WriteLine("the bonus is{0}", bonus);
            Console.WriteLine("the total salary of production employee is {0}", bonus+Salary);
        }
    }
}
