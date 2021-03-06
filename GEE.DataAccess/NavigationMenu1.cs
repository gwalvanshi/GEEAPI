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
    
    public partial class NavigationMenu1
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NavigationMenu1()
        {
            this.UserGroupNavigationMenuMappings = new HashSet<UserGroupNavigationMenuMapping>();
        }
    
        public int NavigationMenuId { get; set; }
        public string NavigationMenuCode { get; set; }
        public string NavigationMenuName { get; set; }
        public int NavigationTypeId { get; set; }
        public int NavigationMenuParentId { get; set; }
        public string MenuURL { get; set; }
        public Nullable<bool> NaviVisible { get; set; }
        public string IconClass { get; set; }
        public string Resxkey { get; set; }
        public string IPAddress { get; set; }
        public string MACAddress { get; set; }
        public string RoleId { get; set; }
        public string RoleName { get; set; }
        public string PermisionName { get; set; }
        public Nullable<int> MenuGroupId { get; set; }
        public Nullable<int> Sessionyear { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int CreatedBy_ID { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public Nullable<int> ModifiedBy_ID { get; set; }
        public Nullable<int> SchoolID { get; set; }
        public Nullable<int> GroupID { get; set; }
        public Nullable<bool> ISDeleted { get; set; }
        public Nullable<int> Sequence { get; set; }
    
        public virtual NavigationType NavigationType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserGroupNavigationMenuMapping> UserGroupNavigationMenuMappings { get; set; }
    }
}
