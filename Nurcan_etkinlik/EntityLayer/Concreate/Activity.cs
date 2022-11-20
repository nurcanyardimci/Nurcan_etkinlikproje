using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concreate
{
    public class Activity

    {
        [Key]
        public int ActivityID { get; set; }
        public string? ActivityName { get; set; }
        public string? ActivityAbout { get; set; }
        public string? ActivityAdress { get; set; }
        public string? ActivityCity { get; set; }
        public string? Limit { get; set; }
        public DateTime ActivityDate { get; set; }
        public DateTime ActivityLastDate { get; set; }
        public bool ActivityTicket { get; set; }
        public string? WriterStatus { get; set; }


        public int CategoryId { get; set; }
       
        public Category? Category { get; set; }
    }
}
