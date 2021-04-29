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
        public double hoursWorked { get; set; }

        public const string EMP_NO = Employee.EMP_NO;
        public const string PROJ_NO = Project.PROJ_NO;
        public const string DATEWORKED = "Date Worked";
        public const string HOURS_WORKED = "Hours Worked";

        public WorksOn(string empNo,string projNo,string dateWorked, double hoursWorked)
        {
            this.empNo = empNo;
            this.projNo = projNo;
            this.dateWorked = dateWorked;
            this.hoursWorked = hoursWorked;
        }
        override
        public string ToString()
        {
            string[] aux = hoursWorked.ToString().Split(',');
            return empNo + ";" + projNo + ";TO_DATE('" + dateWorked + "','dd/mm/yyyy');" + aux[0]+ "."+ (aux.Length>1?aux[1]:"0");
        }
    }
}
