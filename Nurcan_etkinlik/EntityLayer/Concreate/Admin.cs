using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concreate
{
    public class Admin


    {
        [Key]
        public int AdminID { get; set; }

        public string? AdminName { get; set; }


        public string? AdminMail { get; set; }

        public string? AdminPassword { get; set; }


        public string? AdminStatus { get; set; }


        public int AboutID { get; set; }
        
        public About? About  { get; set; }

    }
}
