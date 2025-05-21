namespace Personalregister
{
    internal class PersonalRegister
    {
        private List<Employee> employees = new List<Employee>();

        public bool TryAddEmployee(string input)
        {
            var parts = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            if (parts.Length != 2 || !int.TryParse(parts[1], out int salary))
            {
                return false;
            }

            employees.Add(new Employee(parts[0], salary));
            return true;
        }
       
        public void PrintEmployees()
        {
            if (employees.Count == 0)
            {
                Console.WriteLine("Inga anställda registrerade.");
                return;
            }

            foreach (var emp in employees)
            {
                Console.WriteLine(emp);
            }
        }
    }
}

