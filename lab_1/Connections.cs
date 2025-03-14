using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1
{
    public enum ConnectionType: int 
    {
        WIRED,
        WIRELESS
    }
    public enum Specification: int
    {
        ADSL,
        DOCSIS,
        MOBILE,
        SATELLITE
    }

    public static class Speed
    {
        public const String ADSL = "F";
        public const String DOCSIS = "12C";
        public const String MOBILE = "24";
        public const String SATELLITE = "28";
    }

    public class Connection
    {
        public ConnectionType ConnectionType { get; set; }
        public String Speed { get; set; }
        public Specification Specification { get; set; }
        public bool Vpn { get; set; }



        public Connection(ConnectionType type, String speed, Specification specification, bool vpn)
        {
            ConnectionType = type;
            Speed = speed;
            Specification = specification;
            Vpn = vpn;
        }
    }

    
}
