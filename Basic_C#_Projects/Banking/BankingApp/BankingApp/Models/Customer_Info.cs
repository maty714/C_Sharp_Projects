//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BankingApp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Customer_Info
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string userName { get; set; }
        public string Password { get; set; }
    
        public virtual Customer_Account Customer_Account { get; set; }
    }
}
