using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeClasses
{
    class Program
    {
        static void Main(string[] args)
        {

            #region SingleObject
            // Employee Employee1 = new Employee("Steve","Jobs",1000);

            //Employee1.FirstName1="Steve";
            //Employee1.LastName1 = "Jobs";

            //Employee1.Salary1 = 1000;// set

            //Employee1.DOB1 = new DateTime(1970, 12, 12);
            //Employee1.SSN1 = "777882222";
            //Console.WriteLine(Employee1.Salary1);//get 

            //         Console.WriteLine(Employee1.GetFullName());
            //         Console.WriteLine(Employee1.GetLast4SSN());

            //         Console.WriteLine(Employee1.GetAge().Days/365);

            //Employee1.Address1 =
            //     new USAddress("Woodward Ave.", "48202", "1570", "MI", "Detroit", "3100");


            //         Console.WriteLine(Employee1.Address1.State1);
            #endregion

            // step 1
            List<Employee> EmployeeList = new List<Employee>();

            
            for (int i = 0; i < 2; i++)
            {// step 2 
                string FirstName, LastName;
                float Salary;
                Console.WriteLine("Enter First Name");
                FirstName = Console.ReadLine();
                Console.WriteLine("Enter Last Name");
                LastName = Console.ReadLine();
                Console.WriteLine("Enter Salary");
                Salary = float.Parse(Console.ReadLine());
                EmployeeList.Add(new Employee(FirstName, LastName, Salary));
                // step 3 
  EmployeeList[i].Address1
       = new USAddress("Woodward Ave.", "48202", "1570", "MI", "Detroit", "3100");
            }
            for (int i = 0; i < EmployeeList.Count; i++)
            {
                Console.WriteLine(EmployeeList[i].GetFullName());
                Console.WriteLine(EmployeeList[i].Address1.ZipCode1);
                Console.WriteLine("------------------");
            }

        }
    }
}
