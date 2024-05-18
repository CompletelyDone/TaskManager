namespace TaskManager.Core.Models
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
        public Employee? ProjectManager {  get; set; }

        public List<Employee> Employees { get; set; } = [];

        public Project(Guid _id, string _title, DateTime? _startDate, Guid _orderCompany)
        {
            Id = _id;
            Title = _title;
            StartDate = _startDate;
            OrderCompanyId = _orderCompany;
        }
    }
}
