using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Results;
using GEE.Business.Interface.Admission;
using GEE.Business.Manager.Admission;
using GEE.Business.Models.Admission;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using GEE.Business.Interface.Configuration;
using GEE.Business.Model.Configuration;
using GEE.Common;
using System.Linq;
namespace GEE.API.Controllers.Admission
{
    // [EnableCors(origins: "*", headers: "*", methods: "*")]
    //[Authorize]
    public class EnquiryController : BaseController
    {
        IEnquiry _enquiry;
        ISchoolConfig _schoolConfig;

        public EnquiryController(IEnquiry enquiry, ISchoolConfig schoolConfig)
        {
            _enquiry = enquiry;
            _schoolConfig = schoolConfig;
        }

        [AcceptVerbs("POST")]
        [HttpPost]
        public async Task<HttpResponseMessage> Save(EnquiryModel data)
        {
            try
            {

                #region For Add data into Application table
                List<ApplicationModel> applicationModelList = new List<ApplicationModel>();
                ApplicationModel applicationModel = new ApplicationModel()
                {
                    //Enquiry_ID = enquiry.Enquiry_ID,
                    ApplicaitonNo = data.ApplicaitonNo,
                    IsSubmitted = false,
                    Sessionyear = data.Sessionyear,
                    SchoolID = data.SchoolID,
                    GroupID = data.GroupID,
                    CreatedDate = DateTime.Today

                };
                applicationModelList.Add(applicationModel);
                #endregion

                #region For Add data into CandidateDetail table
                List<CandidateDetailModel> candidateDetailList = new List<CandidateDetailModel>();
                CandidateDetailModel candidateDetailModel = new CandidateDetailModel()
                {
                    // Enquiry_ID = data.Enquiry_ID,
                    AdmissionClass_id = data.AdmissionClass_id,
                    FirstName = data.FirstName,
                    MiddleName = data.MiddleName,
                    Lastname = data.Lastname,
                    DOB = data.DOB,
                    Email = data.Email,
                    StudentType_ID = data.StudentType_ID,
                    ContactMobileNo = data.ContactMobileNo,
                    hasSibiling = data.hasSibiling,
                    SiblingAdmNumber_ID = data.SiblingAdmNumber_ID,
                    Address1 = data.Address1,
                    Address2 = data.Address2,
                    City_ID = data.City_ID,
                    State_ID = data.State_ID,
                    Country_ID = data.Country_ID,
                    FatheFirstName = data.FatheFirstName,
                    FatherMiddleName = data.FatherMiddleName,
                    FatherLasttName = data.FatherLasttName,
                    MotherFirstName = data.MotherFirstName,
                    MotherMiddleName = data.MotherMiddleName,
                    MotherLasttName = data.MotherLasttName,
                    Sessionyear = data.Sessionyear,
                    SchoolID = data.SchoolID,
                    GroupID = data.GroupID,
                    SubjectId = data.SubjectId,
                    CreatedDate = DateTime.Today
                };
                candidateDetailList.Add(candidateDetailModel);

                EnquiryModel enquiry = new EnquiryModel
                {
                    Applications = applicationModelList,
                    CandidateDetails = candidateDetailList,
                    CreatedDate = DateTime.Today,
                    Enquiry_ID = 0,
                    MarketSource_ID = data.MarketSource_ID,
                    EnquiryType_ID = data.EnquiryType_ID,
                    EnquiryNo = data.EnquiryNo

                };
                await _enquiry.SaveAsync(enquiry);
                #endregion
            }
            catch (Exception ex)
            {
                Common.MyLogger.Error(ex.Message + ex.StackTrace + ex.InnerException.ToString());
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Error");
            }
            return Request.CreateResponse(HttpStatusCode.OK, "Data Saved");
        }


        [AcceptVerbs("GET")]
        [HttpGet]
        public async Task<JsonResult<EnquiryModel>> GetAutoGeneraedNo(int id)
        {
            try
            {
          
               var record = _schoolConfig.GetAutoGeneraedNo(id);               
               return await Task.FromResult(Json(record));               
            }
            catch (Exception ex)
            {
                Common.MyLogger.Error(ex.Message + ex.StackTrace + ex.InnerException.ToString());
                return null;
            }
        }

        [AcceptVerbs("GET")]
        [HttpGet]
        [Authorize(Roles =AdmissionConstants.ENQUIRY_GET_ROLE)]
        public JsonResult<List<EnquiryModel>> GetAll()
        {
            try
            {
                var objList = _enquiry.GetAll();
                return Json(objList);
            }
            catch (Exception ex)
            {
                Common.MyLogger.Error(ex.Message + ex.StackTrace + ex.InnerException.ToString());
                return null;
            }
        }
        [AcceptVerbs("GET")]
        [HttpGet]        
        public JsonResult<List<EnquiryModel>> GetAllSearch(string firstName, string lastName)
        {
            try
            {
                var objList = _enquiry.GetAll(firstName, lastName);
                return Json(objList);
            }
            catch (Exception ex)
            {
                Common.MyLogger.Error(ex.Message + ex.StackTrace + ex.InnerException.ToString());
                return null;
            }
        }

        [AcceptVerbs("GET")]
        [HttpGet]
        [Authorize(Roles = AdmissionConstants.ENQUIRY_GET_ROLE)]
        public JsonResult<List<EnquiryModel>> GetEnquiry()
        {
            try
            {
                var objList = _enquiry.GetEnq();

                return Json(objList);
            }
            catch (Exception ex)
            {
                Common.MyLogger.Error(ex.Message + ex.StackTrace + ex.InnerException.ToString());
                return null;
            }
        }

        [AcceptVerbs("GET")]
        [HttpGet]
        public async Task<JsonResult<EnquiryModel>> GetById(int id)
        {
            try
            {
                var record = await _enquiry.GetByIdAsync(id);
                return Json(record);
            }
            catch (Exception ex)
            {
                Common.MyLogger.Error(ex.Message + ex.StackTrace + ex.InnerException.ToString());
                return null;
            }
        }

        [AcceptVerbs("PUT")]
        [HttpPut]
        [Authorize(Roles = AdmissionConstants.ENQUIRY_PUT_ROLE)]
        public async Task<HttpResponseMessage> Update(EnquiryModel data)
        {
            try
            {
                #region For Add data into Application table
                List<ApplicationModel> applicationModelList = new List<ApplicationModel>();
                ApplicationModel applicationModel = new ApplicationModel()
                {
                    Application_ID = data.Application_ID,
                    ApplicaitonNo = data.ApplicaitonNo,
                    IsSubmitted = false,
                    Sessionyear = data.Sessionyear,
                    SchoolID = data.SchoolID,
                    GroupID = data.GroupID,
                    CreatedDate = DateTime.Today

                };
                applicationModelList.Add(applicationModel);
                #endregion

                #region For Add data into CandidateDetail table
                List<CandidateDetailModel> candidateDetailList = new List<CandidateDetailModel>();
                CandidateDetailModel candidateDetailModel = new CandidateDetailModel()
                {
                    CandidateDetail_ID = data.CandidateDetail_ID,
                    AdmissionClass_id = data.AdmissionClass_id,
                    FirstName = data.FirstName,
                    MiddleName = data.MiddleName,
                    Lastname = data.Lastname,
                    DOB = data.DOB,
                    Email = data.Email,
                    StudentType_ID = data.StudentType_ID,
                    ContactMobileNo = data.ContactMobileNo,
                    hasSibiling = data.hasSibiling,
                    SiblingAdmNumber_ID = data.SiblingAdmNumber_ID,
                    Address1 = data.Address1,
                    Address2 = data.Address2,
                    City_ID = data.City_ID,
                    State_ID = data.State_ID,
                    Country_ID = data.Country_ID,
                    FatheFirstName = data.FatheFirstName,
                    FatherMiddleName = data.FatherMiddleName,
                    FatherLasttName = data.FatherLasttName,
                    MotherFirstName = data.MotherFirstName,
                    MotherMiddleName = data.MotherMiddleName,
                    MotherLasttName = data.MotherLasttName,
                    Sessionyear = data.Sessionyear,
                    SchoolID = data.SchoolID,
                    GroupID = data.GroupID,
                    SubjectId = data.SubjectId,
                    CreatedDate = DateTime.Today
                };
                candidateDetailList.Add(candidateDetailModel);
                #endregion
                EnquiryModel enquiry = new EnquiryModel
                {
                    Applications = applicationModelList,
                    CandidateDetails = candidateDetailList,
                    CreatedDate = DateTime.Today,
                    Enquiry_ID = data.Enquiry_ID,
                    MarketSource_ID = data.MarketSource_ID,
                    EnquiryType_ID = data.EnquiryType_ID,
                    EnquiryNo = data.EnquiryNo

                };
                await _enquiry.UpdateAsync(data);
            }
            catch (Exception ex)
            {
                Common.MyLogger.Error(ex.Message + ex.StackTrace + ex.InnerException.ToString());
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Update Error");
            }
            return Request.CreateResponse(HttpStatusCode.OK, "Data Updated");
        }
    }
}