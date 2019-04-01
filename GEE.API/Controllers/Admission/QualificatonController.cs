using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Results;
using GEE.Business.Interface.Admission;
using GEE.Business.Models.Admission;
using GEE.Common;
using NLog;

namespace GEE.API.Controllers.Admission
{
    public class QualificatonController : BaseController
    {
        // GET: Qualificaton
        IQualificaton _iQualificaton;
        public QualificatonController(IQualificaton qualificaton)
        {
            _iQualificaton = qualificaton;
        }


        [AcceptVerbs("POST")]
        [HttpPost]
        public async Task<HttpResponseMessage> Save( QualificatonModel data)
        {
            try
            {
                await _iQualificaton.SaveAsync(data);
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
        public JsonResult<List<QualificatonModel>> GetAll()
        {
            try
            {
                var objList = _iQualificaton.GetAll();
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
        public async Task<JsonResult<QualificatonModel>> GetById(int id)
        {
            try
            {
                var record = await _iQualificaton.GetByIdAsync(id);
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
        public async Task<HttpResponseMessage> Update(QualificatonModel data)
        {
            try
            {
                await _iQualificaton.UpdateAsync(data);
            }
            catch (Exception ex)
            {
                Common.MyLogger.Error(ex.Message + ex.StackTrace + ex.InnerException.ToString());
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Update Error");
            }
            return Request.CreateResponse(HttpStatusCode.OK, "Data Updated");
        }

        [Route("admission/qualifications")]
        [HttpGet]
        public HttpResponseMessage GetQualificaton()
        {
            CustomDataResponseModel customResponseModel = new CustomDataResponseModel();
            try
            {
                QualificatonModel objQualificatonModel = new QualificatonModel();
                List<QualificatonModel> objList = new List<QualificatonModel>();
                 objList = _iQualificaton.GetAll();
               
                if (objList.Count > 0)
                {
                    customResponseModel.type = "success";
                    customResponseModel.message = "";
                    customResponseModel.data = objList;
                }
                else
                {
                    customResponseModel.type = "error";
                    customResponseModel.message = "No records found!";
                    customResponseModel.data = objList;

                }

            }
            catch (Exception ex)
            {
                customResponseModel.type = "error";
                customResponseModel.message = ex.Message;
                customResponseModel.data = null;
                return Request.CreateResponse(HttpStatusCode.ExpectationFailed, customResponseModel);
            }
            return Request.CreateResponse(HttpStatusCode.OK, customResponseModel);
        }

        
    }
}