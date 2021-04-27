using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertCreatorApp.Model
{
    public class Employee
    {
        public string empNo { get; set; }
        public string fName { get; set; }
        public string lName { get; set; }
        public string address1 { get; set; }
        public string DOB { get; set; }
        public char sex { get; set; }
        public string position { get; set; }
        public string deptNo { get; set; }

        public const string EMP_NO = "Employee ID";
        public const string F_NAME = "First Name";
        public const string L_NAME = "Last Name";
        public const string ADDRESS = "Street Address";
        public const string DoB = "Date of Birthday";
        public const string SEX = "Sex";
        public const string POSITION = "Position";
        public const string DEPT_NO = Department.DEPT_NO;

        public Employee(string empNo, string fName, string lName, string address1, string DOB, char sex, string position,string deptNo)
        {
            this.empNo = empNo;
            this.fName = fName;
            this.lName = lName;
            this.address1 = address1;
            this.DOB = DOB;
            this.sex = sex;
            this.position = position;
            this.deptNo = deptNo;
        }
    }
}
