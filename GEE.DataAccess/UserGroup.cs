//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GEE.DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserGroup
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public UserGroup()
        {
            this.UserGroupAspUserMappings = new HashSet<UserGroupAspUserMapping>();
            this.UserGroupNavigationMenuMappings = new HashSet<UserGroupNavigationMenuMapping>();
        }
    
        public int UserGroupId { get; set; }
        public string UserGroupCode { get; set; }
        public string UserGroupName { get; set; }
        public Nullable<int> Sessionyear { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int CreatedBy_ID { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public Nullable<int> ModifiedBy_ID { get; set; }
        public Nullable<int> SchoolID { get; set; }
        public Nullable<int> GroupID { get; set; }
        public Nullable<bool> ISDeleted { get; set; }
        public string UserGroupDescription { get; set; }
        public Nullable<bool> IsDefault { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserGroupAspUserMapping> UserGroupAspUserMappings { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserGroupNavigationMenuMapping> UserGroupNavigationMenuMappings { get; set; }
    }
}
