namespace PortfolioBackend.Models
{
    public class Project
    {
        public string Title { get; set; } // Title of the project
        public List<string> TechnologiesUsed { get; set; } // List of technologies used in the project
        public DateTime DateCreated { get; set; } // Date when the project was created
        public List<TaskDescription> TaskDescriptions { get; set; } // List of descriptions for each task accomplished

        // Constructor to initialize lists
        public Project()
        {
            Title = string.Empty; // Initialize non-nullable property
            TechnologiesUsed = new List<string>();
            TaskDescriptions = new List<TaskDescription>();
        }
    }

    public class TaskDescription
    {
        public string TaskName { get; set; } // Name of the task
        public string Description { get; set; } // Description of the task

        // Constructor to initialize properties
        public TaskDescription()
        {
            TaskName = string.Empty;
            Description = string.Empty;
        }
    }
}
