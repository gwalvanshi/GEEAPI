using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Results;
using GEE.Business.Interface.Admission;
using GEE.Business.Models.Admission;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace GEE.API.Controllers.Admission
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class CandidateDetailController : BaseController
    {
        ICandidateDetail _candidatedetail;

        public CandidateDetailController(ICandidateDetail candidatedetail)
        {
            _candidatedetail = candidatedetail;
        }

        [AcceptVerbs("POST")]
        [HttpPost]
        public async Task<HttpResponseMessage> Save(CandidateDetailModel data)
        {
            try
            {
                await _candidatedetail.SaveAsync(data);
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
        public JsonResult<List<CandidateDetailModel>> GetAll()
        {
            try
            {
                var objList = _candidatedetail.GetAll();
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
        public async Task<JsonResult<CandidateDetailModel>> GetById(int id)
        {
            try
            {
                var record = await _candidatedetail.GetByIdAsync(id);
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
        public async Task<HttpResponseMessage> Update(CandidateDetailModel data)
        {
            try
            {
                await _candidatedetail.UpdateAsync(data);
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
