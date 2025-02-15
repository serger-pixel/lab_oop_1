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

        private String _nameOperator;
        private decimal _priceOfMonth;
        private int _cntUsers;
        private int _speedMb;
        private bool _Support5g;
        private bool _familySharing;
        private bool _routArend;

        public static int cntObj = 0;
        public String NameOperator { get { return _nameOperator; } set { _nameOperator = value; } }
        public decimal PriceOfMonth { get { return _priceOfMonth; } set { _priceOfMonth = value; } }
        public int CntUsers { get { return _cntUsers; } set { _cntUsers = value; } }
        public int SpeedMb { get { return _speedMb; } set { _speedMb = value; } }
        public bool Support5g { get { return _Support5g; } set { _Support5g = value; } }
        public bool FamilySharing { get { return _familySharing; } set { _familySharing = value; } }
        public bool RoutArend { get { return _routArend; } set { _routArend = value; } }


        public readonly static String NAME = "Default";
        public readonly static decimal PRICE = 100;
        public readonly static int CNTUSERS = 1;
        public readonly static int SPEED = 128;
        public readonly static bool SUPPORT5G = false;
        public readonly static bool FAMILYSHARING = false;
        public readonly static bool routArend = false;

        public InternetOperator(String nameOperator, decimal priceOfMonth, 
            int cntUsers, int speedMb, bool Support5g, 
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
            int cntUsers, int speedMb, bool Support5g, bool familySharing): 
            this(nameOperator, priceOfMonth, cntUsers,
                speedMb, Support5g, familySharing, routArend)
        { }

        public InternetOperator(String nameOperator, decimal priceOfMonth,
            int cntUsers, int speedMb, bool Support5g): 
            this(nameOperator, priceOfMonth, cntUsers, 
                speedMb, Support5g, FAMILYSHARING, routArend)
        { }

        public InternetOperator(String nameOperator, decimal priceOfMonth,
            int cntUsers, int speedMb) :
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

        public String ToString()
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

        public void setNameOperator(String nameOperator) {
            _nameOperator = nameOperator;
        }

        public void setPriceOfMonth(decimal priceOfMonth) {
            _priceOfMonth = priceOfMonth;
        }

        public void setCntUsers(int cntUsers) {
            _cntUsers = cntUsers;
        }

        public void setSpeedMb(int speedMb) {
            _speedMb = speedMb;
        }

        public void setSupport5g(bool support5g) {
            _Support5g = support5g;
        }

        public void setFamilySharing(bool FamilySharing) {
            _familySharing = FamilySharing;
        }

        public void setRoutArend(bool routArend) {
            _routArend = routArend;
        }

        public String getNameOperator() {
            return _nameOperator;
        }

        public decimal getPriceOfMonth() {
            return _priceOfMonth;
        }

        public int getCntUsers() {
            return _cntUsers;
        }

        public int getSpeedMb() {
            return _speedMb;
        }

        public bool getSupport5g() {
            return _Support5g;
        }

        public bool getFamilySharing() {
            return _familySharing;
        }

        public bool getRoutArend() {
            return _routArend;
        }


    }
}
