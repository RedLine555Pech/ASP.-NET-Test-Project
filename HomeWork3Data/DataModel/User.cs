//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HomeWork3Data.DataModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        public int UId { get; set; }
        public string Login { get; set; }
        public Nullable<int> Age { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsActive { get; set; }
        public string Email { get; set; }
        public string BlockDescription { get; set; }
        public System.DateTime BirthDay { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public int ImageID { get; set; }
        public string Role { get; set; }
    
        public virtual Image Image { get; set; }
    }
}
