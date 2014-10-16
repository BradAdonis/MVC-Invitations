using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PartyInvites.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage = "Please enter your name")]
        public string name { get; set; }

        [Required(ErrorMessage="Please enter an email address")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage="Please enter a vaild email address")]
        public string email { get; set; }
        [Required(ErrorMessage="Please enter your phone number")]
        public string phone  { get; set; }
        [Required(ErrorMessage="Please specify whether you will attend")]
        public bool? willattend { get; set; }
    }
}