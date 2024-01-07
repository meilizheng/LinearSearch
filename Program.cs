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

            Console.WriteLine("Contains");
            string searchDepartment = "Marketing";
            if(ContainsDepartment(employeeDepartment, searchDepartment))
            {
                Console.WriteLine($"{searchDepartment} includ in employeeDepartment List.");
            }
            else
            {
                Console.WriteLine($"{searchDepartment} doesn't includ in employeeDepartment List.");
            }

            //foreach (var employee in employees)
            //{
            //    Console.WriteLine(employee);
            //}
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
                new Employee("Michael Brown", "Customer Service", "Customer Support Agent"),
                new Employee("Olivia Moore", "Research and Development", "Research Scientist"),
                new Employee("Daniel Taylor", "Legal", "Legal Counsel"),
                new Employee("Grace Turner", "Administration", "Administrative Assistant")
            };
        }
    }
}