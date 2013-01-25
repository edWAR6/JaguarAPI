using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EARTH.Jaguar.Models
{
    public class PublicMessageModel
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public DateTime MessageDate { get; set; }

        [Required]
        public string Message { get; set; }

        //[Required]
        //public DateTime RemainderDate { get; set; }

        //[Required]
        //public bool Active { get; set; }
    }

    public class MessageModel
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public DateTime MessageDate { get; set; }

        [Required]
        public string Message { get; set; }
    }
}