using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Core.Domain
{
    public class Guards
    {
        [Key]
        public int GuardsID { get; set; }

        public int PrisonID { get; set; }
        public Prison Prison { get; set; }

        [MaxLength(50)]
        public string FirstName { get; set; }

        [MaxLength(50)]
        public string LastName { get; set; }

        public int WorkerNumber { get; set; }

        [MaxLength(70)]
        public string Job { get; set; }
    }
}

