using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// ctrl M+O Collapse all 
// ctrl M+L Expand all 
namespace EmployeeClasses
{
    class USAddress
    {
        #region Variables
        private string StreetName;
        private string ZipCode;
        private string HouseNumber;
        private string State;
        private string City;
        private string AptNumber;

        public USAddress(string streetName, string zipCode, string houseNumber, string state, string city, string aptNumber)
        {
            StreetName1 = streetName;
            ZipCode1 = zipCode;
            HouseNumber1 = houseNumber;
            State1 = state;
            City1 = city;
            AptNumber1 = aptNumber;
        }
        #endregion

        #region Properties
        public string StreetName1
        {
            get
            {
                return StreetName;
            }

            set
            {
                StreetName = value;
            }
        }

        public string ZipCode1
        {
            get
            {
                return ZipCode;
            }

            set
            {
                ZipCode = value;
            }
        }

        public string HouseNumber1
        {
            get
            {
                return HouseNumber;
            }

            set
            {
                HouseNumber = value;
            }
        }

        public string State1
        {
            get
            {
                return State;
            }

            set
            {
                State = value;
            }
        }

        public string City1
        {
            get
            {
                return City;
            }

            set
            {
                City = value;
            }
        }

        public string AptNumber1
        {
            get
            {
                return AptNumber;
            }

            set
            {
                AptNumber = value;
            }
        }
        #endregion


    }
}
