﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CheeseMVC.Models
{
    public class Cheese
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public CheeseCategory Category { get; set; }
        public int ID { get; set; }
        public int CategoryID { get; set; }
        IList<CheeseMenu> CheeseMenus = new List<CheeseMenu>();
    }
}
