using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InsertCreatorApp.Model;
using InsertCreatorApp.customExceptions;
using System.IO;

namespace InsertCreatorApp.Ui
{
    public class ControllerGUI
    {
        public Hashtable departments;
        public Hashtable employees;
        public Hashtable projects;
        public Hashtable worksOns;

        public List<String> departmentList;
        public List<String> employeeList;
        public List<String> projectsList;
        public List<String> worksList;
        public string path = @"../../data/DataBase/";
        public ControllerGUI()
        {
            string path = this.path + "DepartmentDATABASE.csv";
            var reader = new System.IO.StreamReader(File.OpenRead(path));
            reader.ReadLine();
            string value = reader.ReadLine();
            while (value != null && value!=" ")
            {
                if (!departmentList.Contains(value))
                {
                    departmentList.Add(value);
                }
                
            }

            path = this.path + "EmployeeDATABASE.csv";
            reader = new System.IO.StreamReader(File.OpenRead(path));
            reader.ReadLine();
            value = reader.ReadLine();
            while (value != null && value != " ")
            {
                if (!employeeList.Contains(value))
                {
                    employeeList.Add(value);
                }

            }

            path = this.path + "ProjectDATABASE.csv";
            reader = new System.IO.StreamReader(File.OpenRead(path));
            reader.ReadLine();
            value = reader.ReadLine();
            while (value != null && value != " ")
            {
                if (!projectsList.Contains(value))
                {
                    projectsList.Add(value);
                }

            }

            path = this.path + "WorksOnDATABASE.csv";
            reader = new System.IO.StreamReader(File.OpenRead(path));
            reader.ReadLine();
            value = reader.ReadLine();
            while (value != null && value != " ")
            {
                if (!worksList.Contains(value))
                {
                    worksList.Add(value);
                }

            }
            departments = new Hashtable();
            employees = new Hashtable();
            projects = new Hashtable();
            worksOns = new Hashtable();
        }
        public void generate(int nd, int ne, int np,int nw)
        {
            Random rnd = new Random();
            for (int i = 0; i < nd; i++)
            {
                int x = rnd.Next(0, departmentList.Count-1);
                string value = departmentList.ElementAt(x);
                string initials = (value.ElementAt(0) + value.ElementAt(1)+"").ToUpper();
                Department department = new Department(initials + i, value, null);
                departments.Add(initials + i, department);
            }

            for (int i = 0; i < ne; i++)
            {
                int x = rnd.Next(0, employeeList.Count-1);
                string value = employeeList.ElementAt(x);
                string[] values = value.Split(';');
                string initials = (values[1].ElementAt(0) + values[1].ElementAt(1) + values[2].ElementAt(2) +"").ToUpper();
                string initials2 = (values[2].ElementAt(0) + values[2].ElementAt(2) + values[2].ElementAt(2) + "").ToUpper();
                Employee employee = new Employee(initials+values[0]+initials2,values[1], values[2], values[3], values[4], values[5].ElementAt(0), values[6],null);
                employees.Add(initials + values[0] + initials2, employee);
            }
            string[] keysDpt = new string[departments.Keys.Count];
            departments.Keys.CopyTo(keysDpt, 0);
            for (int i = 0; i < np; i++)
            {
                int x = rnd.Next(0, projectsList.Count-1);
                string value = projectsList.ElementAt(x);
                string[] values = value.Split(';');
                string key = ('#'+values[1].ElementAt(0) + values[1].ElementAt(1) + i+"*").ToUpper();
                x = rnd.Next(0, keysDpt.Length-1);
                Project project = new Project(key, values[1], keysDpt[x]);
                projects.Add(key,project);
            }

            //Aque agregrar los valores a los NULL

            string[] keysProj = new string[projects.Keys.Count];
            projects.Keys.CopyTo(keysProj, 0);
            for (int i = 0; i < ne; i++)
            {
                int x = rnd.Next(0, worksList.Count - 1);
                string value = worksList.ElementAt(x);
                string[] values = value.Split(';');
                x = rnd.Next(0, keysProj.Length - 1);
                string projNo = keysProj[x];
                Project proj= (Project)projects[projNo];
                Department dept = (Department)departments[proj.deptNo];
                string empNo = dept.empNo;
                WorksOn work = new WorksOn(empNo, projNo, values[0], values[1]);
                worksOns.Add(i,work);
            }
        }

      

        public void openFile()
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/C start ..\\..\\data\\INSERTS";
            process.StartInfo = startInfo;
            process.Start();
        }
        public void generateDepartments(int n)
        {
           

        }
        public void generateEmployees(string empNo)
        {

        }

        public void generateEmployees(int n)
        {
            
        }

        public void generateProjects(int n)
        {
            
        }

        public void generateProjects(string projNo)
        {

        }

        public void generateWorks(int n)
        {
            
        }
    }
}
