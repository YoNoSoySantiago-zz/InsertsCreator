using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InsertCreatorApp.Model;
using System.IO;

namespace InsertCreatorApp.Ui
{
    public class ControllerGUI
    {
        private Hashtable departments;
        private Hashtable employees;
        private Hashtable projects;
        private Hashtable worksOns;

        private Random rnd;

        private List<String> departmentList;
        private List<String> employeeList;
        private List<String> projectsList;

        public string path = @"../../data/DataBase/";
        public ControllerGUI()
        {
            departmentList = new List<string>();
            employeeList = new List<string>();
            projectsList = new List<string>();
            rnd = new Random();
            loadFiles();
        }

        private void loadFiles()
        {
            string path = this.path + "DepartmentDATABASE.csv";
            var reader = new System.IO.StreamReader(File.OpenRead(path));
            reader.ReadLine();
            string value = reader.ReadLine();
            while (value != null && value != " ")
            {
                if (!departmentList.Contains(value))
                {
                    departmentList.Add(value);
                }
                value = reader.ReadLine();
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
                value = reader.ReadLine();
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
                value = reader.ReadLine();
            }
        }

        private void generateDepartments(int n)
        {
            int f = 3;
            for (int i = 0; i < n && f > 0; i++)
            {
                int x = i;
                if (i >= departmentList.Count)
                {
                    x = rnd.Next(0, departmentList.Count - 1);
                }
                string value = departmentList.ElementAt(x);
                string initials = (value.ElementAt(0) + "" + value.ElementAt(1) + "").ToUpper();
                Department department = new Department(initials + "" + x, value, null);
                if (!departments.ContainsKey(initials + "" + x))
                {
                    departments.Add(initials + "" + x, department);
                }
                else if (!departments.ContainsKey(value.ElementAt(0) + "0" + x))
                {
                    department = new Department(value.ElementAt(0) + "0" + x, value + "2", null);
                    departments.Add(value.ElementAt(0) + "0" + x, department);
                }
                else
                {
                    i--;
                    f--;
                }
            }
        }

        private void generateEmployee(int n)
        {
            for (int i = 0; i < n; i++)
            {
                int x = rnd.Next(0, employeeList.Count - 1);
                int y = rnd.Next(0, 99);
                string value = employeeList.ElementAt(x);
                string[] values = value.Split(';');
                string fName = values[0];
                string lName = values[1];
                string initials = (fName.ElementAt(0) + "" + fName.ElementAt(1)).ToUpper();
                string initials2 = (lName.ElementAt(0) + "" + lName.ElementAt(1) + "" + lName.ElementAt(2) + "").ToUpper();
                string empNo = initials + "" + y + "" + initials2;
                string address = streetAddress();
                DateTime dob = RandomDay(new DateTime(1950,1,1),new DateTime(2002,1,1));
                string DOB = dob.ToString().Split(' ')[0];
                char sex = rnd.Next(2) == 0 ? 'F' : 'M';
                string position = values[2];
                Employee employee = new Employee(empNo, fName, lName, address, DOB, sex, position, null);
                if (!employees.ContainsKey(empNo))
                {
                    employees.Add(empNo, employee);
                }
                else
                {
                    i--;
                }

            }
        }
        private DateTime RandomDay(DateTime start, DateTime finish)
        {
            int range = (finish - start).Days;
            return start.AddDays(rnd.Next(range));
        }
        private string streetAddress()
        {
            string[] classificator = { "Cra.", "Cll.","Avenida " };
            string address = classificator[rnd.Next(classificator.Length)];
            address += rnd.Next(99);
            string[] letter = { "A ", "B ", " " };
            address += letter[rnd.Next(letter.Length)];
            address += "#" + rnd.Next(99) + "-" + rnd.Next(99);
            return address;
        }

        private void generateProjects(int n)
        {
            string[] keysDpt = new string[departments.Keys.Count];
            departments.Keys.CopyTo(keysDpt, 0);
            for (int i = 0; i < n; i++)
            {
                int x = rnd.Next(0, projectsList.Count - 1);
                string projName = projectsList.ElementAt(x);
                string key = ("#" + projName.ElementAt(0) + "" + projName.ElementAt(1) + "" + i + "*").ToUpper();
                
                x = rnd.Next(keysDpt.Length);//change
                Project project = new Project(key, projName, keysDpt[x]);
                projects.Add(key, project);
            }
        }

        private void generateDepartmentUpdate()
        {
            string[] EmpKeys = new string[employees.Keys.Count];
            employees.Keys.CopyTo(EmpKeys, 0);
            int i = 0;
            foreach (DictionaryEntry value in departments)
            {
                Department department = (Department)value.Value;
                department.empNo = EmpKeys[i];
                Employee emp = (Employee)employees[EmpKeys[i]];
                emp.deptNo = department.deptNo;
                i++;
            }
        }

        private void generateEmployeeUpdate()
        {
            string[] keysDpt = new string[departments.Keys.Count];
            departments.Keys.CopyTo(keysDpt, 0);
            foreach (DictionaryEntry value in employees)
            {
                Employee employee = (Employee)value.Value;
                if (employee.deptNo == null)
                {
                    int x = rnd.Next(0, keysDpt.Length - 1);
                    employee.deptNo = keysDpt[x];
                }
            }
        }

        private void generateWorks(int n)
        {
            string[] keysProj = new string[projects.Keys.Count];
            projects.Keys.CopyTo(keysProj, 0);
            for (int i = 0; i < n; i++)
            {
                int x = rnd.Next(keysProj.Length);
                string projNo = keysProj[x];
                string dateWorked = RandomDay(new DateTime(2019, 1, 1), DateTime.Today).ToString().Split(' ')[0];
                double hourWorked = Math.Round(rnd.NextDouble()*11+1,2);
                Project proj = (Project)projects[projNo];
                Department dept = (Department)departments[proj.deptNo];
                string empNo = dept.empNo;
                WorksOn work = new WorksOn(empNo, projNo, dateWorked, hourWorked);
                worksOns.Add(i, work);
            }
        }
        public void generate(int nd, int ne, int np,int nw)
        {
            departments = new Hashtable();
            employees = new Hashtable();
            projects = new Hashtable();
            worksOns = new Hashtable();
            generateDepartments(nd);
            generateEmployee(ne);
            generateProjects(np);
            generateDepartmentUpdate();
            generateEmployeeUpdate();
            generateWorks(nw);
            createFile();
        }

        public void createFile()
        {
            StreamWriter writer = new StreamWriter(File.Create("../../data/INSERTS/INSERTS.sql"));
            string lines = inserts();
            writer.WriteLine(lines);
            writer.Close();
            openFile();
        }
        private string inserts()
        {
            string inserts = "";
            foreach (DictionaryEntry value in departments)
            {
                Department department = (Department)value.Value;
                inserts += "INSERT INTO Department VALUES (";
                string[] aux = department.ToString().Split(';');
                for (int i = 0; i < aux.Length - 1; i++)
                {
                    inserts += "'" + aux[i] + "',";
                }
                inserts += "null); \n";
            }
            inserts += "\n \n";
            foreach (DictionaryEntry value in employees)
            {
                Employee employee = (Employee)value.Value;
                inserts += "INSERT INTO Employee VALUES (";
                string[] aux = employee.ToString().Split(';');
                for(int i = 0; i < aux.Length - 1; i++)
                {
                    if (i == 4)
                    {
                        inserts += aux[i] + ",";
                    }
                    else
                    {
                        inserts += "'" + aux[i] + "',"; ;
                    }
                }
                inserts += "null); \n";
            }
            inserts += "\n \n";
            inserts += update();
            inserts += "\n \n";
            foreach (DictionaryEntry value in projects)
            {
                Project project = (Project)value.Value;
                inserts += "INSERT INTO Project VALUES (";
                string[] aux = project.ToString().Split(';');
                for (int i = 0; i < aux.Length ; i++)
                {
                    
                    
                    if (i == aux.Length - 1)
                    {
                        inserts += "'" + aux[i] + "'";
                    }
                    else
                    {
                        inserts += "'" + aux[i] + "',";
                    }
                    
                }
                inserts += "); \n";
            }
            inserts += "\n \n";
            foreach (DictionaryEntry value in worksOns)
            {
                WorksOn project = (WorksOn)value.Value;
                inserts += "INSERT INTO WorksOn VALUES (";
                string[] aux = project.ToString().Split(';');
                for (int i = 0; i < aux.Length ; i++)
                {
                    if (i == 2 )
                    {
                        inserts += aux[i] + ",";
                    }
                    else
                    {
                        if (i == aux.Length - 1)
                        {
                            inserts += "" + aux[i] + "";
                        }
                        else
                        {
                            inserts += "'" + aux[i] +"'," ;
                        }
                    }

                   
                    
                }
                inserts += "); \n";
            }
            return inserts;
        }

        private string update()
        {
            string updates = "";
            foreach (DictionaryEntry value in departments)
            {
                Department department = (Department)value.Value;
                updates += "UPDATE Department SET empNo = '" + department.empNo + "' WHERE Department.deptNo = '" + department.deptNo + "';\n";
            }
            updates += "\n \n";
            foreach (DictionaryEntry value in employees)
            {
                Employee employee = (Employee)value.Value;
                updates += "UPDATE Employee SET deptNo = '" + employee.deptNo + "' WHERE Employee.empNo = '" + employee.empNo + "';\n";
            }
            return updates;
        }
        public void openFile()
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/C explorer ..\\..\\data\\INSERTS";
            process.StartInfo = startInfo;
            process.Start();
        }

    }
}
