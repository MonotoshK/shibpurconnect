//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SCDataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class SCUser
    {
        public SCUser()
        {
            this.UserSecreteMaps = new HashSet<UserSecreteMap>();
        }
    
        public int UserId { get; set; }
        public string Id { get; set; }
        public string Password { get; set; }
        public bool IsDeleted { get; set; }
        public System.DateTime CreateDatetime { get; set; }
        public System.DateTime UpdateDatetime { get; set; }
    
        public virtual ICollection<UserSecreteMap> UserSecreteMaps { get; set; }
    }
}
