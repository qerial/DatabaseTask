using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Core.Domain
{
    public class Prison
    {
        [Key]
        public int PrisonID { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(50)]
        public string Location { get; set; }

        public int MaximumCapacity { get; set; }
        public ICollection<Guards> Guards { get; set; } = new List<Guards>();
        public ICollection<Block> Block { get; set; } = new List<Block>();
        public ICollection<Building> Building { get; set; } = new List<Building>();
    }
}
