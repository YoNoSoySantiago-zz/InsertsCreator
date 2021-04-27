using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertCreatorApp.Model
{
    public class Project
    {
        public string projNo { get; set; }
        public string projName { get; set; }
        public string deptNo { get; set; }

        public const string PROJ_NO = "Project ID";
        public const string PROJ_NAME = "Project Name";
        public const string DEBT_NO = Department.DEPT_NO;

        public Project(string projNo, string projName,string deptNo)
        {
            this.projNo = projNo;
            this.projName = projName;
            this.deptNo = deptNo;
        }
    }
}
