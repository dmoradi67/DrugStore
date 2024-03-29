﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Country
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<State> States { get; set; }
    }
}
