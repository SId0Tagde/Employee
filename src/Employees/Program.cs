// See https://aka.ms/new-console-template for more information
namespace Employee{

    class Program {

        static  void Main(String[] args)
        {
            List<Employees> employees;
            int numbrofempl;
            takeNumber_ofEmployees(out employees, out numbrofempl);

            numbrofempl = takeemployees(employees, numbrofempl);
            printEmployee(employees);
        }


        private static void takeNumber_ofEmployees(out List<Employees> employees, out int numbrofempl)
        {
            employees = new List<Employees>();
            System.Console.WriteLine("Enter number of employees");
            numbrofempl = int.Parse(Console.ReadLine());
        }

        private static void printEmployee(List<Employees> employees)
        {
            foreach (var employee in employees)
            {
                System.Console.WriteLine();
                System.Console.WriteLine($" Employee Id: {employee.GetId()}");
                System.Console.WriteLine($" Name: {employee.GetName()}");
                System.Console.WriteLine($" DepartmentName: {employee.GetDepartmentName()}");
                System.Console.WriteLine();
            }
        }

        private static int takeemployees(List<Employees> employees, int numbrofempl)
        {
            while (numbrofempl != 0)
            {

                Console.WriteLine("Enter Id ,name and Department Name");
                var Id = int.Parse(Console.ReadLine());
                var name = Console.ReadLine();
                var departmentName = Console.ReadLine();

                if (name != null && departmentName != null)
                {
                    var sample = new Employees(Id, name, departmentName);
                    employees.Add(sample);
                    sample.ongetid += Events.ongetid;
                    sample.ongetname += Events.ongetname;
                    sample.ongetdepartmentname += Events.ongetdepartmentname;

                    numbrofempl--;
                }
            }

            return numbrofempl;
        }

    }
    
}
