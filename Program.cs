namespace LinearSearch
{
    internal class Program
    {
        static Employee[] employees;
        static string[] employeeDepartment;
        static string[] employeePosition;
        static void Main(string[] args)
        {

            Preload();

            Contains();

            Console.WriteLine("Employee By Position");
            Console.WriteLine((employeeByPosition(employeePosition, "Accountant")));
            Console.WriteLine((employeeByPosition(employeePosition, "CEO")));

            Console.WriteLine("All Employees of a Department");
            Console.WriteLine(AllEmployeeOfDepartment(employeeDepartment, "IT").Count);
            Console.WriteLine(AllEmployeeOfDepartment(employeeDepartment, "Payroll").Count);

            Console.WriteLine("All Employees of Positon");
            List<Employee> result = AllEmployeeOfPosition(employees, "Software Engineer");
            Console.WriteLine(result.Count);
            foreach (Employee employee in result) { Console.WriteLine($"{employee.Name} - {employee.Position}"); }
            Console.WriteLine(AllEmployeeOfPosition(employees, "Payroll").Count);
        }

        public static bool ContainsDepartment(string[] departmentList, string searchKey)
        {
            foreach (string employee in departmentList)
            {
                if (employee == searchKey)
                {
                    return true;
                }
            }
            return false;
        }

        public static void Contains()
        {
            Console.WriteLine("Contains");
            string searchDepartment = "Marketing";
            if (ContainsDepartment(employeeDepartment, searchDepartment))
            {
                Console.WriteLine($"true. {searchDepartment} includ in employeeDepartment List.");
            }
            else
            {
                Console.WriteLine($"false. {searchDepartment} doesn't includ in employeeDepartment List.");
            }
        }

        public static int employeeByPosition(string[] positionList, string searchKey)
        {
            for (int i = 0; i < positionList.Length; i++)
            {
                if (positionList[i] == searchKey)
                {
                    return i;
                }    
            }
            return -1;
        }

        public static List<int> AllEmployeeOfDepartment(string[] employeeList, string searchKey)
        {
            List<int> result = new List<int>();
            for(int i = 0; i < employeeList.Length; i++)
            {
                if (employeeList[i] == searchKey)
                {
                    result.Add(i);
                }
            }
            return result;
        }

        public static List<Employee> AllEmployeeOfPosition(Employee[] employees, string searchKey)
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
        }
    }
}