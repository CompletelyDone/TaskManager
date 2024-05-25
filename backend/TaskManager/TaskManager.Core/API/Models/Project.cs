namespace TaskManager.Core.API.Models
{
    public class Project
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndedDate { get; set; }

        public Guid OrderCompanyId { get; set; }
        public Company? OrderCompany { get; set; }
        public Guid ExecutorCompanyId { get; set; } = Guid.Empty;
        public Company? ExecutorCompany { get; set; }

        public Guid? ProjectManagerId { get; set; } = Guid.Empty;
        public Employee? ProjectManager { get; set; }

        public List<Employee> Employees { get; set; } = [];

        public Project(Guid id, string title, Guid orderCompany)
        {
            Id = id;
            Title = title;
            OrderCompanyId = orderCompany;
        }
    }
}
