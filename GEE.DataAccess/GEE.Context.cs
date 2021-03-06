﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class GEEDbContext : DbContext
    {
        public GEEDbContext()
            : base("name=GEEDbContext")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<AcademicYear> AcademicYears { get; set; }
        public virtual DbSet<AdmissionDetail> AdmissionDetails { get; set; }
        public virtual DbSet<AdmissionDocumentList> AdmissionDocumentLists { get; set; }
        public virtual DbSet<Application> Applications { get; set; }
        public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUserRole> AspNetUserRoles { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        public virtual DbSet<CandidateDetail> CandidateDetails { get; set; }
        public virtual DbSet<CastCategory> CastCategories { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<ClassMaster> ClassMasters { get; set; }
        public virtual DbSet<CommunicationTemplate> CommunicationTemplates { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Designation> Designations { get; set; }
        public virtual DbSet<DocumentCategory> DocumentCategories { get; set; }
        public virtual DbSet<DocumentSubmissionDetail> DocumentSubmissionDetails { get; set; }
        public virtual DbSet<DocumentType> DocumentTypes { get; set; }
        public virtual DbSet<EmailLog> EmailLogs { get; set; }
        public virtual DbSet<Enquiry> Enquiries { get; set; }
        public virtual DbSet<EnquiryType> EnquiryTypes { get; set; }
        public virtual DbSet<GroupMaster> GroupMasters { get; set; }
        public virtual DbSet<Language> Languages { get; set; }
        public virtual DbSet<LoginTrack> LoginTracks { get; set; }
        public virtual DbSet<MailMerge> MailMerges { get; set; }
        public virtual DbSet<MarketingSource> MarketingSources { get; set; }
        public virtual DbSet<MasterTable> MasterTables { get; set; }
        public virtual DbSet<MasterTabletype> MasterTabletypes { get; set; }
        public virtual DbSet<NavigationMenu> NavigationMenus { get; set; }
        public virtual DbSet<NavigationMenu1> NavigationMenu1 { get; set; }
        public virtual DbSet<NavigationType> NavigationTypes { get; set; }
        public virtual DbSet<NumberGenScheme> NumberGenSchemes { get; set; }
        public virtual DbSet<Qualificaton> Qualificatons { get; set; }
        public virtual DbSet<Registration> Registrations { get; set; }
        public virtual DbSet<Religion> Religions { get; set; }
        public virtual DbSet<SchoolConfig> SchoolConfigs { get; set; }
        public virtual DbSet<SchoolMaster> SchoolMasters { get; set; }
        public virtual DbSet<SMSLog> SMSLogs { get; set; }
        public virtual DbSet<State> States { get; set; }
        public virtual DbSet<StudentType> StudentTypes { get; set; }
        public virtual DbSet<Subject> Subjects { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<tblSize> tblSizes { get; set; }
        public virtual DbSet<tblUnit> tblUnits { get; set; }
        public virtual DbSet<TestTable> TestTables { get; set; }
        public virtual DbSet<UserGroup> UserGroups { get; set; }
        public virtual DbSet<UserGroupAspUserMapping> UserGroupAspUserMappings { get; set; }
        public virtual DbSet<UserGroupNavigationMenuMapping> UserGroupNavigationMenuMappings { get; set; }
        public virtual DbSet<UserMaster> UserMasters { get; set; }
    
        public virtual ObjectResult<FillCombo_Result> FillCombo(string tbName, string fname, string code, string cond)
        {
            var tbNameParameter = tbName != null ?
                new ObjectParameter("TbName", tbName) :
                new ObjectParameter("TbName", typeof(string));
    
            var fnameParameter = fname != null ?
                new ObjectParameter("fname", fname) :
                new ObjectParameter("fname", typeof(string));
    
            var codeParameter = code != null ?
                new ObjectParameter("code", code) :
                new ObjectParameter("code", typeof(string));
    
            var condParameter = cond != null ?
                new ObjectParameter("cond", cond) :
                new ObjectParameter("cond", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<FillCombo_Result>("FillCombo", tbNameParameter, fnameParameter, codeParameter, condParameter);
        }
    
        public virtual ObjectResult<FillComboAdv_Result> FillComboAdv(string tbName)
        {
            var tbNameParameter = tbName != null ?
                new ObjectParameter("TbName", tbName) :
                new ObjectParameter("TbName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<FillComboAdv_Result>("FillComboAdv", tbNameParameter);
        }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    
        public virtual ObjectResult<GetDetails_Result> GetDetails(string enquiryNo)
        {
            var enquiryNoParameter = enquiryNo != null ?
                new ObjectParameter("EnquiryNo", enquiryNo) :
                new ObjectParameter("EnquiryNo", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetDetails_Result>("GetDetails", enquiryNoParameter);
        }
    
        public virtual ObjectResult<GetMaster_Result> GetMaster(string tableName)
        {
            var tableNameParameter = tableName != null ?
                new ObjectParameter("TableName", tableName) :
                new ObjectParameter("TableName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetMaster_Result>("GetMaster", tableNameParameter);
        }
    
        public virtual ObjectResult<GetMasterDropDown_Result> GetMasterDropDown(string tableName)
        {
            var tableNameParameter = tableName != null ?
                new ObjectParameter("TableName", tableName) :
                new ObjectParameter("TableName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetMasterDropDown_Result>("GetMasterDropDown", tableNameParameter);
        }
    
        public virtual ObjectResult<GetMasterForDropDown_Result> GetMasterForDropDown(string tableName)
        {
            var tableNameParameter = tableName != null ?
                new ObjectParameter("TableName", tableName) :
                new ObjectParameter("TableName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetMasterForDropDown_Result>("GetMasterForDropDown", tableNameParameter);
        }
    
        public virtual ObjectResult<GetMasterOfAll_Result> GetMasterOfAll(string tableName)
        {
            var tableNameParameter = tableName != null ?
                new ObjectParameter("TableName", tableName) :
                new ObjectParameter("TableName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetMasterOfAll_Result>("GetMasterOfAll", tableNameParameter);
        }
    
        public virtual ObjectResult<GetReligion_Result> GetReligion()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetReligion_Result>("GetReligion");
        }
    
        public virtual ObjectResult<GetMenu_Result> GetMenu(string userName, Nullable<byte> action)
        {
            var userNameParameter = userName != null ?
                new ObjectParameter("UserName", userName) :
                new ObjectParameter("UserName", typeof(string));
    
            var actionParameter = action.HasValue ?
                new ObjectParameter("Action", action) :
                new ObjectParameter("Action", typeof(byte));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetMenu_Result>("GetMenu", userNameParameter, actionParameter);
        }
    }
}
