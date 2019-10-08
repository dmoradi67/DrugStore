using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class State
    {

        public int Id { get; set; }
        public string StateName { get; set; }
        public int Population { get; set; }
        public String Description { get; set; }

        public Country Country { get; set; }
        public int CountryId { get; set; }
        public ICollection<City> cities { get; set; }
    }
}
