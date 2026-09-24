using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Visitors
    {
        [Key]
        public int VisitorID { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        public int PersonalNumber { get; set; }
        public int TelephoneNumber { get; set; }
        [MaxLength(15)]
        public string RelationToPrisoner { get; set; }
    }
}
