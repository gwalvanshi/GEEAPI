using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GEE.Business.Models;

namespace GEE.Business.Model.Admin
{
    public  class AspNetUserModel:BaseEntity
    {
        public AspNetUserModel()
        {
            this.AspNetUserClaims = new List<AspNetUserClaimModel>();
            this.AspNetUserLogins = new List<AspNetUserLoginModel>();
            this.AspNetUserRoles = new List<AspNetUserRoleModel>();
        }
        public string Id { get; set; }
        public string Email { get; set; }
        public bool EmailConfirmed { get; set; }
        public string PasswordHash { get; set; }
        public string SecurityStamp { get; set; }
        public string PhoneNumber { get; set; }
        public bool PhoneNumberConfirmed { get; set; }
        public bool TwoFactorEnabled { get; set; }
        public DateTime? LockoutEndDateUtc { get; set; }
        public bool LockoutEnabled { get; set; }
        public int AccessFailedCount { get; set; }
        public string UserName { get; set; }
        public int ? Sessionyear { get; set; }      
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ? StuStaffTypeId { get; set; }
        public int ? UserGroupId { get; set; }
        public int ? CUserId { get; set; }
        public  List<AspNetUserClaimModel> AspNetUserClaims { get; set; }
        public List<AspNetUserLoginModel> AspNetUserLogins { get; set; }
        public List<AspNetUserRoleModel> AspNetUserRoles { get; set; }
    }
}
