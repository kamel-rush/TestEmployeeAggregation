using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeClasses
{
    class Employee
    {
        public static int Count = 0; 

        private float Salary;

        private string FirstName;
        private string LastName; 
        private string SSN;
        private string ID;
        private string JobTitle;
        private string DeptName;
        private string OfficePhoneNumber;
        private USAddress Address;

        private DateTime HireDate;
        private DateTime DOB;

        #region Variables 
        public float Salary1
        {
            get
            {
                return Salary;
            }

            set
            {
                Salary = value;
            }
        }

        public string FirstName1
        {
            get
            {
                return FirstName;
            }

            set
            {
                FirstName = value;
            }
        }

        public string LastName1
        {
            get
            {
                return LastName;
            }

            set
            {
                LastName = value;
            }
        }

        public string SSN1
        {
            get
            {
                return SSN;
            }

            set
            {
                SSN = value;
            }
        }

        public string ID1
        {
            get
            {
                return ID;
            }

            set
            {
                ID = value;
            }
        }

        public string JobTitle1
        {
            get
            {
                return JobTitle;
            }

            set
            {
                JobTitle = value;
            }
        }

        public string DeptName1
        {
            get
            {
                return DeptName;
            }

            set
            {
                DeptName = value;
            }
        }

        public string OfficePhoneNumber1
        {
            get
            {
                return OfficePhoneNumber;
            }

            set
            {
                OfficePhoneNumber = value;
            }
        }

        public USAddress Address1
        {
            get
            {
                return Address;
            }

            set
            {
                Address = value;
            }
        }

        public DateTime HireDate1
        {
            get
            {
                return HireDate;
            }

            set
            {
                HireDate = value;
            }
        }

        public DateTime DOB1
        {
            get
            {
                return DOB;
            }

            set
            {
                DOB = value;
            }
        }

        #endregion

        public Employee(string Fn, string Ln, float Sal)
        {
            FirstName = Fn;
            LastName = Ln;
            //Salary = Sal; // Bypass the property 

            Salary1 = Sal; 
        }

        public Employee()
        {

        }


        public string GetLast4SSN()
        {
            return SSN.Substring(5);

        }

        public TimeSpan GetAge()
        {
           return  DateTime.Now - DOB;

        }

        public string GetFullName()
        {
            return FirstName1 + " " + LastName1; 
        }

    }
}
