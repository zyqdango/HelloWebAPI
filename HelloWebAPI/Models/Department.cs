﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HelloWebAPI.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name{get; set; }
        public decimal Budget { get; set; }
    }
}