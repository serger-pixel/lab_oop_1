using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_oop_1
{
    internal static class IntOperConsts
    {
        public const String KeyNameOperator = "nameOperator";
        public const String KeyPriceOfMonth = "priceOfMonth";
        public const String KeycntUsers = "cntUsers";
        public const String KeySpeedMb = "speedMb";
        public const String KeySupport5g = "Support5g";
        public const String KeyfamilySharing = "familySharing";
        public const String KeyRoutArend = "routArend";
        public const String KeyAll = "All";

        public const String NAME = "Default";
        public const decimal PRICE = 100;
        public const int CNTUSERS = 0;
        public const int SPEED = 128;
        public const bool SUPPORT5G = false;
        public const bool FAMILYSHARING = false;
        public const bool routArend = false;
    }

    internal class InternetOperator
    {

        private String _nameOperator;
        private decimal _priceOfMonth;
        private int _cntUsers;
        private int _speedMb;
        private bool _Support5g;
        private bool _familySharing;
        private bool _routArend;

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
        }

        public InternetOperator(String nameOperator, decimal priceOfMonth,
            int cntUsers, int speedMb, bool Support5g, bool familySharing): 
            this(nameOperator, priceOfMonth, cntUsers,
                speedMb, Support5g, familySharing, IntOperConsts.routArend)
        { }

        public InternetOperator(String nameOperator, decimal priceOfMonth,
            int cntUsers, int speedMb, bool Support5g): 
            this(nameOperator, priceOfMonth, cntUsers, 
                speedMb, Support5g, IntOperConsts.FAMILYSHARING, IntOperConsts.routArend)
        { }

        public InternetOperator(String nameOperator, decimal priceOfMonth,
            int cntUsers, int speedMb) :
            this(nameOperator, priceOfMonth, cntUsers,
                speedMb, IntOperConsts.SUPPORT5G, IntOperConsts.FAMILYSHARING, IntOperConsts.routArend)
        { }

        public InternetOperator(String nameOperator, decimal priceOfMonth,
            int cntUsers) :
            this(nameOperator, priceOfMonth, cntUsers,
                IntOperConsts.SPEED, IntOperConsts.SUPPORT5G, IntOperConsts.FAMILYSHARING, IntOperConsts.routArend)
        { }

        public InternetOperator(String nameOperator, decimal priceOfMonth) :
            this(nameOperator, priceOfMonth, IntOperConsts.CNTUSERS,
                IntOperConsts.SPEED, IntOperConsts.SUPPORT5G, IntOperConsts.FAMILYSHARING, IntOperConsts.routArend)
        { }

        public InternetOperator(String nameOperator) :
            this(nameOperator, IntOperConsts.PRICE, IntOperConsts.CNTUSERS,
                IntOperConsts.SPEED, IntOperConsts.SUPPORT5G, IntOperConsts.FAMILYSHARING, IntOperConsts.routArend)
        { }

        public InternetOperator() :
            this(IntOperConsts.NAME, IntOperConsts.PRICE, IntOperConsts.CNTUSERS,
                IntOperConsts.SPEED, IntOperConsts.SUPPORT5G, IntOperConsts.FAMILYSHARING, IntOperConsts.routArend)
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
