﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Dal.Modules
{
    public class Currency
    {
        public int CurCode { get; set; }
        public string CurName { get; set; }

        public override string ToString()
        {
            string str = string.Format(" {0} {1}", CurName, CurCode);
            return str;
        }

    }
    public class Product
    {
        private double Price_;        
        public string Name { get; set; }
        public double Price
        {
            get { return Price_; }
            set
            {
                if (value < 0)
                {
                    Price_ = 0;
                }
                else
                    Price_ = value;
            }
        }
        public int Barcode { get; set; }
        public Currency Cur { get; set; } = new Currency();
        public int Quantity { get; set; }
        public double ExpiredDay { get; set; }
        public DateTime DateOfProduction { get; set; }

        private DateTime ExpiredTime_;
        public DateTime ExpiredTime
        {
            get  { return ExpiredTime_; }
            set
            {
                double TotalDays = (value - DateOfProduction).TotalDays;

                if (TotalDays < 0)
                {
                    ExpiredTime_ = DateOfProduction.AddDays(ExpiredDay);
                }
                else if (TotalDays > ExpiredDay)
                {
                    ExpiredTime_ = DateOfProduction.AddDays(ExpiredDay);
                }
                else
                    ExpiredTime_ = value;
            }
        }

        public static Product operator > (Product a, Product b)
        {
            if (a.Price > b.Price)
                return a;
            else
                return b;
        }
        public static Product operator < (Product a, Product b)
        {
            if (a.Price < b.Price)
                return b;
            else
                return a;
        }

        public void PrintInfo()
        {
            Console.WriteLine("{0} - {1} - {3} - {4} {5}", 
                Barcode, Name, DateOfProduction, ExpiredTime, Price, Cur);
        }
    }
}
