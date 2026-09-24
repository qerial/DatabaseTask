using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Prisoners
    {
        [Key]
        public int PrisonerID { get; set; }
        public Chamber ChamberID { get; set; }
        public Punishment PunishmentID { get; set; }
        [MaxLength(50)]
        public string FirstName { get; set; }
        [MaxLength(50)]
        public string LastName { get; set; }
        public DateTime DOB { get; set; }
        public int PersonalNumber { get; set; }
        public DateTime ArrivalDate { get; set; }
        public bool PrisonerStatus { get; set; }
        public Crime CrimeID { get; set; }

    }
}
