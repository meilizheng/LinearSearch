namespace LinearSearch   //nameSpace
{
    internal class Program  //class
    {
        //Declare the global arrays
        static Employee[] employees;
        static string[] employeeDepartment;
        static string[] employeePosition;
        static void Main(string[] args)  //Main
        {

            Preload();

            Contains();//Call Contains Method

            Console.WriteLine("Employee By Position");
            Console.WriteLine((employeeByPosition(employeePosition, "Accountant")));// 1
            Console.WriteLine((employeeByPosition(employeePosition, "CEO")));// -1

            Console.WriteLine("All Employees of a Department");
            Console.WriteLine(AllEmployeeOfDepartment(employeeDepartment, "IT").Count); //2
            Console.WriteLine(AllEmployeeOfDepartment(employeeDepartment, "Payroll").Count); //0

            Console.WriteLine("All Employees of Positon");
            List<Employee> result = AllEmployeeOfPosition(employees, "Software Engineer");
            Console.WriteLine(result.Count);  // 2
            foreach (Employee employee in result) { Console.WriteLine($"{employee.Name} - {employee.Position}"); }
            Console.WriteLine(AllEmployeeOfPosition(employees, "Payroll").Count);  //0
        } //End Main

        public static bool ContainsDepartment(string[] departmentList, string searchKey) //ContainsDepartment method check if the departmentName in department list
        {
            foreach (string department in departmentList) //use foreach check every department name in the list. Linear Search
            {
                if (department == searchKey)  //if found
                {
                    return true; //return true
                }
            }
            return false;  //else return false
        }

        public static void Contains()
        {
            Console.WriteLine("Contains");
            string searchDepartment = "Marketing";
            if (ContainsDepartment(employeeDepartment, searchDepartment))
            {
                Console.WriteLine($"true. {searchDepartment} includ in employeeDepartment List.");//if Marketing in department list return true
            }
            else
            {
                Console.WriteLine($"false. {searchDepartment} doesn't includ in employeeDepartment List.");//else return false
            }
        }

        public static int employeeByPosition(string[] positionList, string searchKey)  //employeeByPosition method check position's index
        {
            for (int i = 0; i < positionList.Length; i++)
            {
                if (positionList[i] == searchKey)
                {
                    return i;
                }    
            }
            return -1;  //return -1 if not found
        }

        public static List<int> AllEmployeeOfDepartment(string[] departmentList, string searchKey)  //AllEmployeeOfDepartment method check department total number in employeeDepartment
        {
            List<int> result = new List<int>();
            for(int i = 0; i < departmentList.Length; i++)
            {
                if (departmentList[i] == searchKey)
                {
                    result.Add(i);
                }
            }
            return result;
        }

        public static List<Employee> AllEmployeeOfPosition(Employee[] employees, string searchKey) //AllEmployeeOfPosition method check total position in employee list
        {
            List<Employee> employeeOfPosition = new List<Employee>();
            foreach(Employee employee in employees)
            {
                if (employee.Position == searchKey)
                {
                    employeeOfPosition.Add(employee);
                }
            }
            return employeeOfPosition;
        }

        static void Preload()
        {
            employeeDepartment = new string[]
            {
                "Marketing",
                "Human Resources",
                "Finance",
                "IT",
                "Operations",
                "Sales",
                "Customer Service",
                "Research and Development",
                "Legal",
                "Administration"
            };

            employeePosition = new string[]
            {
                "Manager",
                "HR Specialist",
                "Accountant",
                "Software Engineer",
                "Operations Manager",
                "Sales Representative",
                "Customer Support Agent",
                "Research Scientist",
                "Legal Counsel",
                "Administrative Assistant"
            };

            employees = new Employee[]
            {
                new Employee("John Doe", "Marketing", "Manager"),
                new Employee("Alice Smith", "Human Resources", "HR Specialist"),
                new Employee("Bob Johnson", "Finance", "Accountant"),
                new Employee("Sara Miller", "IT", "Software Engineer"),
                new Employee("David Williams", "Operations", "Operations Manager"),
                new Employee("Emily Davis", "Sales", "Sales Representative"),
                new Employee("Michael Brown", "IT", "Software Engineer"),
                new Employee("Olivia Moore", "Research and Development", "Research Scientist"),
                new Employee("Daniel Taylor", "Legal", "Legal Counsel"),
                new Employee("Grace Turner", "Administration", "Administrative Assistant")
            };
        } //End Preload
    } //End Class
} //End nameSpace