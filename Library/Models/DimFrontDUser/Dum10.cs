﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Models.DimFrontDUser
{
    public class Sub11d
    {
        public Int64 sid { get; set; }
        public string nat { get; set; }
        public double b { get; set; }
        public double bs { get; set; }
        public double l { get; set; }
        public double ls { get; set; }
        public int sr { get; set; }
        public string gstatus { get; set; }
        public double min { get; set; }
        public double max { get; set; }
        public string subtype { get; set; }
        //public string gtype { get; set; }
        public int gval { get; set; }
    }

    public class Data61d
    {
        public long mid { get; set; }
        public int lt { get; set; }
        public int ft { get; set; }
        public string card { get; set; }
        public string gtype { get; set; }
        public string rdesc { get; set; }
        public string remark { get; set; }
        public string lcard { get; set; }
        public Int64 csum { get; set; }
        public List<Sub11d> sub { get; set; }
    }

    public class Dum10
    {
        public int status { get; set; }
        public string msg { get; set; }
        public Data61d data { get; set; }
    }
}
