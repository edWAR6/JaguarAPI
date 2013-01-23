using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace EARTH.Jaguar.Models
{
    public class LogOnModel
    {
        [Required]        
        public string UserName { get; set; }

        [Required]        
        public string Password { get; set; }
    }
}
