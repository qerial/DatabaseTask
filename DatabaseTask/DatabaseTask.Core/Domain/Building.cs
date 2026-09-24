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
        public Prison PrisonID { get; set; }

    }
}
