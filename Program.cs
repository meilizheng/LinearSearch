namespace LinearSearch
{
    internal class Program
    {
        static Employee[] employees;
        static void Main(string[] args)
        {

            Preload();

            foreach (var employee in employees)
            {
                Console.WriteLine(employee);
            }
        }

        static void Preload()
        {
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