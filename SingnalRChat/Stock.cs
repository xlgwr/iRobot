﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SingnalRChat
{
    public class Stock
    {
        private decimal _price;
        public string Symbol { get; set; }
        public decimal DayOpen { get;private set; }
        public decimal Price
        {
            get
            {
                return _price;
            }
            set
            {
                if (_price == value)
                {
                    return;
                }
                _price = value;
                if (DayOpen == 0)
                {
                    DayOpen = _price;
                }
            }
        }
        public decimal Change
        {
            get { return Price - DayOpen; }
        }
        public double PercentChange
        {
            get
            {
                return (double)Math.Round(Change / Price, 4);
            }
        }
    }

}