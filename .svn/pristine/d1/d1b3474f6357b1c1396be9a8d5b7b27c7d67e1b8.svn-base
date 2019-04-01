using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using GEE.Business.Models.Admission;
using GEE.Business.Model.Admin;
using GEE.DataAccess;
using GEE.Business.Model.Admission;
using GEE.Business.Model.Configuration;
namespace GEE.Business.Manager
{
    public class AutoMapperConfig
    {
        public static void Initialize()
        {
            Mapper.Initialize((config) =>
            {
               
                config.CreateMap<Enquiry, EnquiryModel>().ReverseMap();
                config.CreateMap<ClassMaster, ClassesModel>().ReverseMap();
                config.CreateMap<AcademicYear, AcademicYearModel>().ReverseMap();
                config.CreateMap<CastCategory, CastCategoryModel>().ReverseMap();
                config.CreateMap<Qualificaton, QualificatonModel>().ReverseMap();
                config.CreateMap<EnquiryType, EnquiryTypeModel>().ReverseMap();
                config.CreateMap<tblUnit, UnitModel>().ReverseMap();
                config.CreateMap<tblSize, SizeModel>().ReverseMap();
                config.CreateMap<Application, ApplicationModel>().ReverseMap();
                config.CreateMap<CandidateDetail, CandidateDetailModel>().ReverseMap();
                config.CreateMap<DocumentSubmissionDetail, DocumentSubmissionModel>().ReverseMap();
                config.CreateMap<Registration, RegistrationModel>().ReverseMap();
               config.CreateMap<MarketingSource, MarketingSourceModel>().ReverseMap();
                //config.CreateMap<GEE.DataAccess.AspNetUser, Model.Admin.AspNetUserModel>().ReverseMap();
                //config.CreateMap<GEE.DataAccess.AspNetRole, Model.Admin.AspNetRoleModel>().ReverseMap();
                //config.CreateMap<GEE.DataAccess.AspNetUserRole, Model.Admin.AspNetUserRoleModel>().ReverseMap();
                config.CreateMap<UserGroup, UserGroupModel>().ReverseMap();
                config.CreateMap<UserGroupAspUserMapping, UserGroupAspUserMappingModel>().ReverseMap();
                config.CreateMap<UserGroupNavigationMenuMapping, UserGroupNavigationMenuMapping>().ReverseMap();
                config.CreateMap<NavigationType, NavigationTypeModel>().ReverseMap();
                config.CreateMap<NavigationMenu, NavigationMenuModel>().ReverseMap();
                //config.CreateMap<GetMenu_Result, GetMenuModel>().ReverseMap();
                config.CreateMap<LoginTrack, LoginTrackModel>().ReverseMap();

                config.CreateMap<CommunicationTemplate, CommunicationTemplate>().ReverseMap();
                config.CreateMap<EmailLog, EmailLog>().ReverseMap();
                config.CreateMap<SMSLog, SMSLog>().ReverseMap();
                config.CreateMap<MailMerge, MailMerge>().ReverseMap();
                config.CreateMap<SchoolConfig, SchoolConfigModel>().ReverseMap();
                config.CreateMap<NumberGenScheme, NumberGenSchemeModel>().ReverseMap();
                config.CreateMap<MasterTable, MasterTableModel>().ReverseMap();
                config.CreateMap<AspNetUser, AspNetUserModel>().ReverseMap();
            });
        }

    }
}
