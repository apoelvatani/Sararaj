using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityLayer.Concrete
{
    public class Comment
    {
        [Key]
        public int ID { get; set; }
        public string User { get; set; }
        public DateTime Date { get; set; }
        public string Content { get; set; }
        public string State { get; set; }
        public int DestinationID { get; set; }
        public Destination Destination { get; set; }
    }
}
