using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concreate
{
    public class User

    {
        [Key]
        public int UserID { get; set; }
        public string? UserName { get; set; }
        public string? UserMail { get; set; }
        public string? UserPassword { get; set; }
        public string? UserPassword2 { get; set; }
        public string? UserStatus { get; set; }


        public int AboutID { get; set; }
        public About? About { get; set; }
    }
}
