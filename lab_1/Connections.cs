using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1
{
    public enum CONNECTIONTYPES: int 
    {
        WIRED,
        WIRELESS
    }
    public enum SPECIFICATIONS: int
    {
        ADSL,
        DOCSIS,
        MOBILE,
        SATELLITE
    }

    public class Connection
    {
        public CONNECTIONTYPES ConnectionType { get; set; }
        public String Speed { get; set; }
        public SPECIFICATIONS Specification { get; set; }

        public Connection(CONNECTIONTYPES type, String speed, SPECIFICATIONS specification)
        {
            ConnectionType = type;
            Speed = speed;
            Specification = specification;
        }
    }

    
}
