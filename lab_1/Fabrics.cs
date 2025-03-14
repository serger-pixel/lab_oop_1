using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1
{
    public interface IFabric
    {
        public Connection createADSL();
        public Connection createDOCSIS();
        public Connection createMobile();
        public Connection createSatellite();


    }

    public class FabricVpnSup : IFabric
    {
        public Connection createADSL() 
        {
            return new Connection(ConnectionType.WIRED, Speed.ADSL, 
                Specification.ADSL, true);
        }
        public Connection createDOCSIS()
        {
            return new Connection(ConnectionType.WIRED, Speed.DOCSIS, 
                Specification.DOCSIS, true);
        }
        public Connection createMobile()
        {
            return new Connection(ConnectionType.WIRELESS, Speed.MOBILE,
                Specification.MOBILE, true);
        }

        public Connection createSatellite()
        {
            return new Connection(ConnectionType.WIRELESS, Speed.SATELLITE, 
                Specification.SATELLITE, true);
        }
    }

    public class FabricVpnNoSup : IFabric
    {
        public Connection createADSL()
        {
            return new Connection(ConnectionType.WIRED, Speed.ADSL,
                Specification.ADSL, false);
        }
        public Connection createDOCSIS()
        {
            return new Connection(ConnectionType.WIRED, Speed.DOCSIS,
                Specification.DOCSIS, false);
        }
        public Connection createMobile()
        {
            return new Connection(ConnectionType.WIRELESS, Speed.MOBILE,
                Specification.MOBILE, false);
        }

        public Connection createSatellite()
        {
            return new Connection(ConnectionType.WIRELESS, Speed.SATELLITE,
                Specification.SATELLITE, false);
        }
    }
}