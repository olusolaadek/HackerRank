namespace DesignerPdfViewer
{
    public class EmployeeData
    {
        public static void EmployeeTester()
        {
            var empList = new List<Employee>();
            empList.Add(new Employee() { Age = 25, Company = "PAL", FirstName = "Olaegbe", LastName = "Kayode" });
            empList.Add(new Employee() { Age = 64, Company = "PAL", FirstName = "Ige", LastName = "Hakeem" });
            empList.Add(new Employee() { Age = 44, Company = "PAL", FirstName = "Igwe", LastName = "Joe" });

            empList.Add(new Employee() { Age = 35, Company = "Cazoo", FirstName = "Imoh", LastName = "Sunday" });
            empList.Add(new Employee() { Age = 38, Company = "Cazoo", FirstName = "Kaz", LastName = "Owowo" });
            empList.Add(new Employee() { Age = 42, Company = "Cazoo", FirstName = "Ola", LastName = "Aina" });

            empList.Add(new Employee() { Age = 35, Company = "Goden", FirstName = "Trent", LastName = "Anold" });
            empList.Add(new Employee() { Age = 45, Company = "Goden", FirstName = "Bello", LastName = "Jaja" });
            empList.Add(new Employee() { Age = 22, Company = "Goden", FirstName = "Badmus", LastName = "Itunu" });
            empList.Add(new Employee() { Age = 20, Company = "Goden", FirstName = "Iwa", LastName = "Lewa" });

            //  AverageAgeForEachCompany
            Console.WriteLine("============AverageAgeForEachCompany==========");
            var avgs = AverageAgeForEachCompany(empList);
            Console.WriteLine("Company\tAverage Age");
            foreach (var item in avgs)
            {
                Console.WriteLine("{0}\t{1}", item.Key, item.Value);
            }

             
            //  AverageAgeForEachCompany
            Console.WriteLine("============AverageAgeForEachCompany==========");

            var counts = CountOfEmployeesForEachCompany(empList);
            Console.WriteLine("Company\tEmployee Count");
            foreach (var item in counts)
            {
                Console.WriteLine("{0}\t{1}", item.Key, item.Value);
            }
            //  AverageAgeForEachCompany
            Console.WriteLine("============OldestAgeForEachCompany==========");

            var oldestEmps = CountOfEmployeesForEachCompany(empList);
            Console.WriteLine("Company\tEmployee Count");
            foreach (var item in oldestEmps)
            {
                Console.WriteLine("{0}\t{1}", item.Key, item.Value);
            }
        }
        public static Dictionary<string, int> AverageAgeForEachCompany(List<Employee> employees)
        {
            var result = employees.GroupBy(s => s.Company)
                     .Select(g => new { Company = g.Key, Avg = g.Average(s => s.Age) });

            Dictionary<string, int> avgs = new Dictionary<string, int>();
            foreach (var value in result)
            {
                avgs.Add(value.Company, (int)value.Avg);
            }

            return avgs;
        }
       

        public static Dictionary<string, int> CountOfEmployeesForEachCompany(List<Employee> employees)
        {
            var result = employees.GroupBy(s => s.Company)
                     .Select(g => new { Company = g.Key, Count = g.Count() });

            Dictionary<string, int> avgs = new Dictionary<string, int>();
            foreach (var value in result)
            {
                avgs.Add(value.Company, (int)value.Count);
            }

            return avgs;
        }

        public static Dictionary<string, Employee> OldestAgeForEachCompany(List<Employee> employees)
        {
            var results = employees.GroupBy(s => s.Company)
                .Select(g => new { Company = g.Key, Employee=g.FirstOrDefault(), Oldest = g.Max(s => s.Age) });

            Dictionary<string, Employee> oldestEmployees = new Dictionary<string, Employee>();
            foreach (var value in results)
            {
                oldestEmployees.Add(value.Company,value.Employee);
            }

            return oldestEmployees;
        }
    }

    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Company { get; set; }
    }

}
