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
    
    public partial class SecreteQuestionMaster
    {
        public SecreteQuestionMaster()
        {
            this.UserSecreteMaps = new HashSet<UserSecreteMap>();
        }
    
        public int QuestionId { get; set; }
        public string Question { get; set; }
        public string QuestionHint { get; set; }
        public System.DateTime CreateDatetime { get; set; }
        public System.DateTime UpdateDatetime { get; set; }
    
        public virtual ICollection<UserSecreteMap> UserSecreteMaps { get; set; }
    }
}
