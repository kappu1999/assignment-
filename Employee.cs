using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    class Employee // class
    {
        private int ID;
        private string Name;
        private string DepartmentName;
        public Employee(int ID,string Name,string DepartmentName)   //constructor
        {
            this.ID = ID;
            this.Name = Name;
            this.DepartmentName = DepartmentName;
        }
        public int GetId()
        {
        return this.ID;
        }
        public string GetName()
        {
        return this.Name;
        }
        public string GetDepartmentName()
        {
        return this.DepartmentName;
        }
        static void Main(string[] args)
        {
            Employee E1 = new Employee(11,"kapil","IT");
            
            Console.WriteLine("employee id is {0}",E1.GetId());
            Console.WriteLine("employee name is {0}",E1.GetName());
            Console.WriteLine("employee department name is {0}",E1.GetDepartmentName());
            Console.ReadLine();
        }
    }
}