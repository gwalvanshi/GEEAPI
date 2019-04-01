﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEE.Business.Model.Admin
{
   public class AspNetUserLoginModel
    {
        public string LoginProvider { get; set; }
        public string ProviderKey { get; set; }
        public string UserId { get; set; }
        public int? Sessionyear { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int? CreatedBy_ID { get; set; }
        public System.DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy_ID { get; set; }
        public int? SchoolID { get; set; }
        public int? GroupID { get; set; }
        public bool? ISDeleted { get; set; }

        public virtual AspNetUserModel AspNetUser { get; set; }
    }
}
