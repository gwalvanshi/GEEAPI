using System;
using Unity;
using GEE.Business.Interface.Admission;
using GEE.Business.Interface.Admin;
//using GEE.Business.Manager.Admin;
using System.Data.Entity;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
using GEE.API.Models;
using Unity.Injection;
using Microsoft.Owin.Security.DataHandler;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.DataHandler.Encoder;
using Microsoft.Owin.Security.DataHandler.Serializer;
using Microsoft.Owin.Security.DataProtection;
using Unity.Lifetime;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using Owin;
using GEE.Business.Interface.Configuration;
using GEE.Business.Interface.Security;

namespace GEE.API
{
    /// <summary>
    /// Specifies the Unity configuration for the main container.
    /// </summary>
    public static class UnityConfig
    {
        #region Unity Container
        private static Lazy<IUnityContainer> container =
          new Lazy<IUnityContainer>(() =>
          {
              var container = new UnityContainer();
              RegisterTypes(container);
              return container;
          });

        /// <summary>
        /// Configured Unity Container.
        /// </summary>
        public static IUnityContainer Container => container.Value;
        #endregion

        /// <summary>
        /// Registers the type mappings with the Unity container.
        /// </summary>
        /// <param name="container">The unity container to configure.</param>
        /// <remarks>
        /// There is no need to register concrete types such as controllers or
        /// API controllers (unless you want to change the defaults), as Unity
        /// allows resolving a concrete type even if it was not previously
        /// registered.
        /// </remarks>
        public static void RegisterTypes(IUnityContainer container)
        {
            // NOTE: To load from web.config uncomment the line below.
            // Make sure to add a Unity.Configuration to the using statements.
            // container.LoadConfiguration();

            // TODO: Register your type's mappings here.
           
            container.RegisterType<IEnquiry, GEE.Business.Manager.Admission.EnquiryManager>();
            container.RegisterType<IApplication, GEE.Business.Manager.Admission.ApplicationManager>();
            container.RegisterType<ISchoolConfig, GEE.Business.Manager.Configuration.SchoolConfigManager>();
            container.RegisterType<IApplication, GEE.Business.Manager.Admission.ApplicationManager>();

            container.RegisterType<ICandidateDetail, GEE.Business.Manager.Admission.CandidateManager>();
            container.RegisterType<IClasses, GEE.Business.Manager.Admission.ClassesManager>();
            container.RegisterType<IAcademicYear, GEE.Business.Manager.Admission.AcademicYearManager>();
            container.RegisterType<ICastCategory, GEE.Business.Manager.Admission.CastCategoryManager>();
            container.RegisterType<IQualificaton, GEE.Business.Manager.Admission.QualificatonManager>();
            container.RegisterType<IEnquiryType, GEE.Business.Manager.Admission.EnquiryTypeManager>();
            container.RegisterType<IUnit, GEE.Business.Manager.Admission.UnitManager>();
            container.RegisterType<IFillCombo, GEE.Business.Manager.Admission.LookupsManager>();
           
            container.RegisterType<IUserStore<ApplicationUser>, UserStore<ApplicationUser>>();
            container.RegisterType<UserManager<ApplicationUser>>();
            container.RegisterType<DbContext, ApplicationDbContext>();
            container.RegisterType<ApplicationUserManager>();

           container.RegisterType<IRoleStore<IdentityRole, string>,RoleStore<IdentityRole>>();      
            container.RegisterType<RoleManager<IdentityRole>, ApplicationRoleManager>();           
     
            container.RegisterType<Controllers.Admin.AccountController>(new InjectionConstructor());
        
            container.RegisterType<IUserGroup, GEE.Business.Manager.Admin.UserGroupManager>();
            container.RegisterType<IUserGroupAspUserMapping, GEE.Business.Manager.Admin.UserGroupAspUserMappingManager>();
            container.RegisterType<IUserGroupNavigationMenuMapping, GEE.Business.Manager.Admin.UserGroupNavigationMenuMappingManager>();
            container.RegisterType<INavigationType, GEE.Business.Manager.Admin.NavigationTypeManager>();
            container.RegisterType<INavigationMenu, GEE.Business.Manager.Admin.NavigationMenuManager>();
            container.RegisterType<ILoginTrack, GEE.Business.Manager.Admin.LoginTrackManager>();
            container.RegisterType<IGetMenu, GEE.Business.Manager.Admin.GetMenuManager>();
            container.RegisterType<INavigationPermission, GEE.Business.Manager.Security.NavigationPermissionManager>();
            container.RegisterType<IMasterTable, GEE.Business.Manager.Admin.MasterTableManager>();
            container.RegisterType<IAspNetUser, GEE.Business.Manager.Admin.AspNetUserManager>();
        }
    }
}