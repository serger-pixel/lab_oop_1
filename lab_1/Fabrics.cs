using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1
{
    public interface IFabric
    {
        public Connection createADSLConnection();
        public Connection createDOCSISConnection();
        public Connection createMobileConnection();
        public Connection createSatelliteConnection();


    }

    public class FabricVpnSup : IFabric
    {
        public Connection createADSLConnection() 
        {
            return new Connection(CONNECTIONTYPES.WIRED, ConnectionConsts.ADSLSPEED, 
                SPECIFICATIONS.ADSL, ConnectionConsts.VPNSUP);
        }
        public Connection createDOCSISConnection()
        {
            return new Connection(CONNECTIONTYPES.WIRED, ConnectionConsts.DOCSISSPEED, 
                SPECIFICATIONS.DOCSIS, ConnectionConsts.VPNSUP);
        }
        public Connection createMobileConnection()
        {
            return new Connection(CONNECTIONTYPES.WIRELESS, ConnectionConsts.MOBILESPEED,
                SPECIFICATIONS.MOBILE, ConnectionConsts.VPNSUP);
        }

        public Connection createSatelliteConnection()
        {
            return new Connection(CONNECTIONTYPES.WIRELESS, ConnectionConsts.SATELLITESPEED, 
                SPECIFICATIONS.SATELLITE, ConnectionConsts.VPNSUP);
        }
    }

    public class FabricVpnNoSup : IFabric
    {
        public Connection createADSLConnection()
        {
            return new Connection(CONNECTIONTYPES.WIRED, ConnectionConsts.ADSLSPEED,
                SPECIFICATIONS.ADSL, ConnectionConsts.VPNNOSUP);
        }
        public Connection createDOCSISConnection()
        {
            return new Connection(CONNECTIONTYPES.WIRED, ConnectionConsts.DOCSISSPEED,
                SPECIFICATIONS.DOCSIS, ConnectionConsts.VPNNOSUP);
        }
        public Connection createMobileConnection()
        {
            return new Connection(CONNECTIONTYPES.WIRELESS, ConnectionConsts.MOBILESPEED,
                SPECIFICATIONS.MOBILE, ConnectionConsts.VPNNOSUP);
        }

        public Connection createSatelliteConnection()
        {
            return new Connection(CONNECTIONTYPES.WIRELESS, ConnectionConsts.SATELLITESPEED,
                SPECIFICATIONS.SATELLITE, ConnectionConsts.VPNNOSUP);
        }
    }
}