using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSEC_Project.Classes.DB_Classes
{
    public class Msec : Base
    {
        public string MsecLocation { get; set; }
        public string MsecProfile { get; set; }
        public DateTime DocumentsInDate { get; set; }
        public DateTime StartExpertisionDate { get; set; }
        public DateTime InspectionOfPacientDate { get; set; }
        public DateTime DecisionMakingDate { get; set; }
        public DateTime EndExpertisionDate { get; set; }
        //foreign key
        public Guid ActId { get; set; }
    }
}
