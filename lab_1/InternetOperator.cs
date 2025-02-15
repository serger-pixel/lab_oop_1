using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1
{
    public static class IntOperConsts
    {
        public const String KeyNameOperator = "nameOperator";
        public const String KeyPriceOfMonth = "priceOfMonth";
        public const String KeycntUsers = "cntUsers";
        public const String KeySpeedMb = "speedMb";
        public const String KeySupport5g = "Support5g";
        public const String KeyfamilySharing = "familySharing";
        public const String KeyRoutArend = "routArend";
        public const String KeyAll = "All";
    }

    public class InternetOperator
    {
        public readonly static String NAME = "Default";
        public readonly static decimal PRICE = 100;
        public readonly static int CNTUSERS = 1;
        public readonly static String SPEED = "0x80";
        public readonly static bool SUPPORT5G = false;
        public readonly static bool FAMILYSHARING = false;
        public readonly static bool routArend = false;

        private String _nameOperator;
        private decimal _priceOfMonth;
        private int _cntUsers;
        private String _speedMb;
        private bool _Support5g;
        private bool _familySharing;
        private bool _routArend;

        public static int cntObj = 0;
        public String NameOperator { get { return _nameOperator; } set { _nameOperator = value; } }
        public decimal PriceOfMonth { get { return _priceOfMonth; } set { _priceOfMonth = value; } }
        public int CntUsers { get { return _cntUsers; } set { _cntUsers = value; } }
        public String SpeedMb { get { return _speedMb; } set { _speedMb = value; } }
        public bool Support5g { get { return _Support5g; } set { _Support5g = value; } }
        public bool FamilySharing { get { return _familySharing; } set { _familySharing = value; } }
        public bool RoutArend { get { return _routArend; } set { _routArend = value; } }

        public InternetOperator(String nameOperator, decimal priceOfMonth, 
            int cntUsers, String speedMb, bool Support5g, 
            bool familySharing, bool routArend)
        {
            _nameOperator = nameOperator;
            _priceOfMonth = priceOfMonth;
            _cntUsers = cntUsers;
            _speedMb = speedMb;
            _Support5g = Support5g;
            _familySharing = familySharing;
            _routArend = routArend;
            cntObj++;
        }

        public InternetOperator(String nameOperator, decimal priceOfMonth,
            int cntUsers, String speedMb, bool Support5g, bool familySharing): 
            this(nameOperator, priceOfMonth, cntUsers,
                speedMb, Support5g, familySharing, routArend)
        { }

        public InternetOperator(String nameOperator, decimal priceOfMonth,
            int cntUsers, String speedMb, bool Support5g): 
            this(nameOperator, priceOfMonth, cntUsers, 
                speedMb, Support5g, FAMILYSHARING, routArend)
        { }

        public InternetOperator(String nameOperator, decimal priceOfMonth,
            int cntUsers, String speedMb) :
            this(nameOperator, priceOfMonth, cntUsers,
                speedMb, SUPPORT5G, FAMILYSHARING, routArend)
        { }

        public InternetOperator(String nameOperator, decimal priceOfMonth,
            int cntUsers) :
            this(nameOperator, priceOfMonth, cntUsers,
                SPEED, SUPPORT5G, FAMILYSHARING, routArend)
        { }

        public InternetOperator(String nameOperator, decimal priceOfMonth) :
            this(nameOperator, priceOfMonth, CNTUSERS,
                SPEED, SUPPORT5G, FAMILYSHARING, routArend)
        { }

        public InternetOperator(String nameOperator) :
            this(nameOperator, PRICE, CNTUSERS,
                SPEED, SUPPORT5G, FAMILYSHARING, routArend)
        { }

        public InternetOperator() :
            this(NAME, PRICE, CNTUSERS,
                SPEED, SUPPORT5G, FAMILYSHARING, routArend)
        { }

        public override String ToString()
        {
            return
                "Имя: " + _nameOperator + "\n" +
                "Цена: " + _priceOfMonth + "\n" +
                "Кол-во пользовотелей: " + _cntUsers + "\n" +
                "Скорость интернета: " + _speedMb + "\n" +
                "Поддержка 5g" + _Support5g + "\n" +
                "Поддержка семейного тарифа" + _familySharing + "\n" +
                "Аренда роутера" + _routArend;
        }
    }
}
