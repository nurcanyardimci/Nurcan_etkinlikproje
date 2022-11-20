using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concreate
{
    public class About
    {
        [Key]
        public int AboutID { get; set; }
        public string? AboutDetails1 { get; set; }
        public string? AboutDetails2  { get; set; }
        public string? AboutImage1  { get; set; }
        public string? AboutImage2   { get; set; }
        public string? AboutMapLocation { get; set; }
        public bool AboutStatus { get; set; }


       
        public List<Admin>? Admins { get; set; }
       
        public List<User>? Users  { get; set; }
     
        public List<Writer>? Writers  { get; set; }
    }
}
