using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Chamber
    {
        [Key]
        public int BlockID { get; set; }
        public Prison PrisonID { get; set; }
        public int number { get; set; }
        public int floor { get; set; }
        public int MaximumCapacity { get; set; }
    }
}
