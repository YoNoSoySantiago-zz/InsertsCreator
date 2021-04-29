using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertCreatorApp.Model
{
    
    public class Department
    {
        public string deptNo { get; set; }
        public string deptName { get; set; }
        public string empNo { get; set; }


        //Constants
        public const string DEPT_NO = "Department ID";
        public const string DEPT_NAME = "Department name";
        public const string EMP_NO = Employee.EMP_NO;

        public Department(string deptNo,string deptName, string empNo)
        {
            this.deptNo = deptNo;
            this.deptName = deptName;
            this.empNo = empNo;
        }

        override
        public string ToString()
        {
            return deptNo + ";" + deptName + ";" + empNo;
        }
    }
}
