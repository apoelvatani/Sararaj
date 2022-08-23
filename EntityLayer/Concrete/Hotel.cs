using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer.Concrete
{
    public class Hotel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public int RoomCount { get; set; }
        public int BuildingYear { get; set; }
        public int Price { get; set; }
    }
}
