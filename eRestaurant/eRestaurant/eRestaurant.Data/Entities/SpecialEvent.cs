using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace eRestaurant.Data
{
    public class SpecialEvent
    {
        public int Eventcode { get; set; }
        public string Description { get; set; }
        public byte Active { get; set; }
    }
}