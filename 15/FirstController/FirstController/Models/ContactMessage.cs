using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FirstController.Models
{
    public class ContactMessage
    {
        [Required(ErrorMessage="Please provide your name.")]
        [Display(Name="Your Name")]
        public string CustomerName { get; set; }

        [Required(ErrorMessage="Please provide your email address.")]
        [EmailAddress(ErrorMessage="Please provide a valid email address.")]
        [Display(Name="Your Email Address")]
        public string CustomerEmail { get; set; }

        [Required(ErrorMessage="Please provide your message.")]
        [Display(Name="Tell Us What's on Your Mind")]
        public string CustomerMessage { get; set; }
    }
}