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
    public class DocumentTypeController : BaseController
    {
        IDocumentType _documentType;

        public DocumentTypeController(IDocumentType documentType)
        {
            _documentType = documentType;
        }
        [AcceptVerbs("GET")]
        [HttpGet]
        public JsonResult<List<DocumentTypeModel>> GetAll()
        {
            try
            {
                var objList = _documentType.GetAll();
                return Json(objList);
            }
            catch (Exception ex)
            {
                Common.MyLogger.Error(ex.Message + ex.StackTrace + ex.InnerException.ToString());
                return null;
            }
        }
    }
}