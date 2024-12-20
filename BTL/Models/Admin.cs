//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BTL.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Admin
    {
        public Admin()
        {
            this.Contacts = new HashSet<Contact>();
        }
    
        public int AdminID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public System.DateTime BirthDate { get; set; }
        public string HomeTown { get; set; }
        public string IdentityCard { get; set; }
        public string VerificationCode { get; set; }
        public Nullable<System.DateTime> VerificationCodeExpiration { get; set; }
        public string URLPicture { get; set; }
        public string Role { get; set; }
    
        public virtual ICollection<Contact> Contacts { get; set; }
    }
}
