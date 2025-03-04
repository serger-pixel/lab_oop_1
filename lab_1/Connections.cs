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

    public static class ConnectionConsts
    {
        public const String ADSLSPEED = "F";
        public const String DOCSISSPEED = "12C";
        public const String MOBILESPEED = "24";
        public const String SATELLITESPEED = "28";

        public const bool VPNSUP = true;
        public const bool VPNNOSUP = false;

    }

    public class Connection
    {
        public CONNECTIONTYPES ConnectionType { get; set; }
        public String Speed { get; set; }
        public SPECIFICATIONS Specification { get; set; }
        public bool Vpn { get; set; }



        public Connection(CONNECTIONTYPES type, String speed, SPECIFICATIONS specification, bool vpn)
        {
            ConnectionType = type;
            Speed = speed;
            Specification = specification;
            Vpn = vpn;
        }
    }

    
}
