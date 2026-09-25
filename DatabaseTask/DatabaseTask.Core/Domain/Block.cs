using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Block
    {
        [Key]
        public int BlockID { get; set; }

        public int PrisonID { get; set; }
        public Prison Prison { get; set; }

        public int number { get; set; }

        [MaxLength(60)]
        public string Name { get; set; }

        public int SecurityLevel { get; set; }
    }
}
