namespace PortfolioBackend.Models
{
    public class Project
    {
        public string Title { get; set; }
        public string Url { get; set; }
        public List<string> TechnologiesUsed { get; set; }
        public DateTime DateCreated { get; set; }
        public List<TaskDescription> TaskDescriptions { get; set; }

        public Project()
        {
            Title = string.Empty;
            TechnologiesUsed = new List<string>();
            TaskDescriptions = new List<TaskDescription>();
        }
    }

    public class TaskDescription
    {
        public string TaskName { get; set; }
        public string Description { get; set; }

        public TaskDescription()
        {
            TaskName = string.Empty;
            Description = string.Empty;
        }
    }
}
