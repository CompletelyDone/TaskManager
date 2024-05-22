namespace TaskManager.Core.Models
{
    public class Company
    {
        public Guid Id { get; set; }
        public string Title { get; set; }

        public List<Employee> Employees { get; set; } = [];
        public List<Project> ExecutingProjects { get; set; } = [];
        public List<Project> OrderedProjects { get; set; } = [];

        public Company(Guid id, string title)
        {
            Id = id;
            Title = title;
        }
    }
}
