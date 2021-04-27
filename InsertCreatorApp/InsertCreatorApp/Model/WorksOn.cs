using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertCreatorApp.Model
{
    public class WorksOn
    {
        public string empNo { get; set; }
        public string projNo { get; set; }
        public string dateWorked { get; set; }
        public string hoursWorked { get; set; }

        public const string EMP_NO = Employee.EMP_NO;
        public const string PROJ_NO = Project.PROJ_NO;
        public const string DATEWORKED = "Date Worked";
        public const string HOURS_WORKED = "Hours Worked";

        public WorksOn(string empNo,string projNo,string dateWorked,string hoursWorked)
        {
            this.empNo = empNo;
            this.projNo = projNo;
            this.dateWorked = dateWorked;
            this.hoursWorked = hoursWorked;
        }
    }
}
