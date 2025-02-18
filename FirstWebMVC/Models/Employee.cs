namespace FirstWebMVC.Models
{
    public class Employee
    {
        public long Id { get; set; }
        public string FullName { get; set; }
        public string Department { get; set; }

        public Employee(long id, string fullName, string department)
        {
            Id = id;
            FullName = fullName;
            Department = department;
        }
    }
}
