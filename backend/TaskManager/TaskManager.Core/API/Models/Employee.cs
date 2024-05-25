namespace TaskManager.Core.API.Models
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

        public Employee(Guid id, string name, string surname, string email, string password)
        {
            Id = id;
            Name = name;
            Surname = surname;
            Email = email;
            HashedPassword = password;
        }
    }
}
