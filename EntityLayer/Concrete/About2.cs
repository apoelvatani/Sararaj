using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityLayer.Concrete
{
    public class About2
    {
        [Key]
        public int ID { get; set; }
        public string Title1 { get; set; }
        public string Title2 { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
    }
}
