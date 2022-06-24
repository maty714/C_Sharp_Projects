using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Banking.Models
{
    public class userAccount
    {
        [Key]
        public string AccountId { get; set; }
        public string accountType { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
    }
}