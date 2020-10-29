﻿using System;
using System.Collections.Generic;

namespace DbDatabaseOfCore.Models
{
    public partial class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductPrice { get; set; }
        public int? CategoryId { get; set; }

        public virtual Category Category { get; set; }
    }
}
