using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1
{
    public static class ConnectionConsts 
    {
        public const String ADSLSPEED = "F";
        public const String DOCSISSPEED = "12C";
        public const String MOBILESPEED = "24";
        public const String SATELLITESPEED = "28";
    } 

    public interface IFabric
    {
        public Connection createConnection();
    }

    public class FabricADSL : IFabric
    {
        
        public Connection createConnection() 
        {
            return new Connection(CONNECTIONTYPES.WIRED, ConnectionConsts.ADSLSPEED, SPECIFICATIONS.ADSL);
        }
    }

    public class FabricDOCSIS : IFabric
    {

        public Connection createConnection()
        {
            return new Connection(CONNECTIONTYPES.WIRED, ConnectionConsts.DOCSISSPEED, SPECIFICATIONS.DOCSIS);
        }
    }

    public class FabricMobile : IFabric
    {

        public Connection createConnection()
        {
            return new Connection(CONNECTIONTYPES.WIRELESS, ConnectionConsts.MOBILESPEED, SPECIFICATIONS.MOBILE);
        }
    }

    public class FabricSatellite : IFabric
    {

        public Connection createConnection()
        {
            return new Connection(CONNECTIONTYPES.WIRELESS, ConnectionConsts.SATELLITESPEED, SPECIFICATIONS.SATELLITE);
        }
    }
}
