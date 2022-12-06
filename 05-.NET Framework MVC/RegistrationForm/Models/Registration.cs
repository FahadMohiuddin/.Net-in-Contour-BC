using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RegistrationForm.Models
{
    public class Registration
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public double phone { get; set; }   
        public string address { get; set; } 
        public string pass { get; set; }    
    }
}