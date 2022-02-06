﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeAdam.Tests.Dummy
{
    public class Product
    {
        public string Name { get; set; }
    }
    public abstract class Category: ITestInterface
    {
        public string Name { get; set; }
    }
    interface ITestInterface
    {
        public string Name { get; set; }
    }
}
