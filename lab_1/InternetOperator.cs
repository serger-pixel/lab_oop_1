﻿using System;
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
        public const String KeyAll = "All";

        public const string DELETING = "Удаление элемента: ";
        public const string ADDING = "Добавление элемента: ";
        public const string EDITING = "Изменение элемента: ";
        public const string TITLE = "Изменение";

        public const String UPKEYS = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        public const String DOWNKEYS = "abcdefghijklmnopqrstuvwxyz";
        public const int MINLENGEN = 4;
    }

    public interface IInternetOperator
    {
        public String NameOperator { get; set; }
        public decimal PriceOfMonth { get; set; }
        public int CntUsers { get; set; }
        public Connection Connection { get; set; }
    }

    public class DiscountDecorator: IInternetOperator
    {
        private InternetOperator _localOperator;

        private decimal _discount = 0;

        public DiscountDecorator(InternetOperator localOperator, decimal discount)
        {
            _localOperator = localOperator;
            _discount = discount;
        }

        public String NameOperator {
            get{
                return _localOperator.NameOperator;
            }

            set { 
                _localOperator.NameOperator = value;
            }
        }
        public decimal PriceOfMonth
        {
            get
            {
                return _localOperator.PriceOfMonth - _discount;
            }

            set
            {
                _localOperator.PriceOfMonth = value;
            }
        }
        public int CntUsers
        {
            get
            {
                return _localOperator.CntUsers;
            }

            set
            {
                _localOperator.CntUsers = value;
            }
        }
        public Connection Connection
        {
            get
            {
                return _localOperator.Connection;
            }

            set
            {
                _localOperator.Connection = value;
            }
        }
    }

    public class InternetOperator: IInternetOperator
    {
        public const String NAME = "Default";
        public const decimal PRICE = 100;
        public const int CNTUSERS = 1;
        

        public static int cntObj = 0;
        public String NameOperator { get; set; }
        public decimal PriceOfMonth { get; set; }
        public int CntUsers { get; set; }
        public Connection Connection { get; set; }

        public InternetOperator(String nameOperator, decimal priceOfMonth, 
            int cntUsers, Connection connection)
        {
            NameOperator = nameOperator;
            PriceOfMonth = priceOfMonth;
            CntUsers = cntUsers;
            Connection = connection;
        }

        public InternetOperator(String nameOperator, decimal priceOfMonth, int cntUsers)
        {
            NameOperator = nameOperator;
            PriceOfMonth = priceOfMonth;
            CntUsers = cntUsers;
            Connection = new FabricVpnNoSup().createMobile();
        }

        public InternetOperator(String nameOperator, decimal priceOfMonth): 
            this(nameOperator, priceOfMonth, CNTUSERS)
        { }

        public InternetOperator(String nameOperator) :
            this(nameOperator, PRICE, CNTUSERS)
        { }


        public InternetOperator() :
            this(NAME, PRICE, CNTUSERS)
        { }

        public override String ToString()
        {
            return
                "Имя: " + NameOperator + "\n" +
                "Цена: " + PriceOfMonth + "\n" +
                "Кол-во пользовотелей: " + CntUsers + "\n" +
                "Скорость интернета: " + Connection.Speed + "\n" +
                "Тип подключения: " + Connection.ConnectionType + "\n" +
                "Спецификация подключения: " + Connection.Specification + "\n" +
                "Поддержка VPN: " + Connection.Vpn;

        }

    }
}
