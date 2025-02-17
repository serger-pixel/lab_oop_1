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

        //private String _nameOperator;
        //private decimal _priceOfMonth;
        //private int _cntUsers;
        //private String _speedMb;
        //private bool _Support5g;
        //private bool _familySharing;
        //private bool _routArend;

        public static int cntObj = 0;
        public String NameOperator { get; set; }
        public decimal PriceOfMonth { get; set; }
        public int CntUsers { get; set; }
        public String SpeedMb { get; set; }
        public bool Support5g { get; set; }
        public bool FamilySharing { get; set; }
        public bool RoutArend { get;  set; }

        public InternetOperator(String nameOperator, decimal priceOfMonth, 
            int cntUsers, String speedMb, bool support5g, 
            bool familySharing, bool routArend)
        {
            NameOperator = nameOperator;
            PriceOfMonth = priceOfMonth;
            CntUsers = cntUsers;
            SpeedMb = speedMb;
            Support5g = support5g;
            FamilySharing = familySharing;
            RoutArend = routArend;
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
                "Имя: " + NameOperator + "\n" +
                "Цена: " + PriceOfMonth + "\n" +
                "Кол-во пользовотелей: " + CntUsers + "\n" +
                "Скорость интернета: " + SpeedMb + "\n" +
                "Поддержка 5g" + Support5g + "\n" +
                "Поддержка семейного тарифа" + FamilySharing + "\n" +
                "Аренда роутера" + RoutArend;
        }
    }
}
