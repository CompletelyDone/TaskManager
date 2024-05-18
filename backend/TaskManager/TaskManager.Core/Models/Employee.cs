namespace TaskManager.Core.Models
{
    public class Employee
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string? Patronomic { get; set; }
        public Guid? CompanyId { get; set; }
        public Company? Company { get; set; }
        public string Email { get; set; }
        public string HashedPassword { get; set; }

        public List<Project> Projects { get; set; } = [];
        public List<ProjectTasks> Tasks { get; set; } = [];

        public Employee(
            Guid _id, string _name, string _surname, string? _patronomic, 
            Guid? _companyId,
            string _email, string _password)
        {
            Id = _id;
            Name = _name;
            Surname = _surname;
            CompanyId = _companyId;
            Patronomic = _patronomic;
            Email = _email;
            HashedPassword = _password;
        }
    }
}
