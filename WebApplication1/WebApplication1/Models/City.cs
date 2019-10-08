using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class City
    {
        public int Id { get; set; }
        public string CityName { get; set; }
        public int MyProperty { get; set; }


        public State State { get; set; }
        public int StateId { get; set; }
    }
}
