using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Building
    {
        [Key]
        public int BuildingsID { get; set; }

        public int PrisonID { get; set; }
        public Prison Prison { get; set; }
    }
}
