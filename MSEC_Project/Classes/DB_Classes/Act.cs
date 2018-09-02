using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSEC_Project.Classes.DB_Classes
{
    public class Act : Base
    {
        public int ActNumber { get; set; }
        public DateTime ActDate { get; set; }
        public Msec MsecInfo { get; set; }
        
    }
}
