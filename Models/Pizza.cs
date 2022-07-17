using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaStore.Models
{
    public class Pizza
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string DataCriacao { get; set; }    

    }
}