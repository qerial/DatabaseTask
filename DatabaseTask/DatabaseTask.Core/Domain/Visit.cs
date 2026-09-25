using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Visit
    {
        [Key]
        public int VisitID { get; set; }

        public int VisitorsID { get; set; }
        public Visitors Visitors { get; set; }

        public int PrisonerID { get; set; }
        public Prisoners Prisoner { get; set; }

        public DateTime Date { get; set; }
        public int StartTime { get; set; }
        public int EndTime { get; set; }

        [MaxLength(60)]
        public string VisitingStatus { get; set; }
    }
}
