using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Results;
using GEE.Business.Interface.DocumentLibrary;
using GEE.Business.Models.DocumentLibrary;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace GEE.API.Controllers.DocumentLibrary
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class DocumentSubmissionController : BaseController
    {

        IDocumentSubmission _documentSubmission;

        public DocumentSubmissionController(IDocumentSubmission documentSubmission)
        {
            _documentSubmission = documentSubmission;
        }

        [AcceptVerbs("POST")]
        [HttpPost]
        public async Task<DocumentSubmissionModel> Save(DocumentSubmissionModel data)
        {
            DocumentSubmissionModel objDocsub = new DocumentSubmissionModel();
            try
            {
                return await _documentSubmission.SaveAsync(data);
              
            }
            catch (Exception ex)
            {
                Common.MyLogger.Error(ex.Message + ex.StackTrace + ex.InnerException.ToString());
                return null;
            }
            
        }

        [AcceptVerbs("GET")]
        [HttpGet]
        public JsonResult<List<DocumentSubmissionModel>> GetAll()
        {
            try
            {
                var objList = _documentSubmission.GetAll();
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
        public async Task<JsonResult<DocumentSubmissionModel>> GetById(int id)
        {
            try
            {
                var record = await _documentSubmission.GetByIdAsync(id);
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
        public async Task<HttpResponseMessage> Update(DocumentSubmissionModel data)
        {
            try
            {
                await _documentSubmission.UpdateAsync(data);
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