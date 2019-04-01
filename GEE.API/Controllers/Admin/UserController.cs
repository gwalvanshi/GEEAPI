using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Results;
using GEE.Business.Interface.Admin;
using GEE.Business.Model.Admin;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using GEE.Common;
namespace GEE.API.Controllers.Admin
{
    public class UserController:BaseController
    {
        IAspNetUser _iAspNetUser;
        public UserController(IAspNetUser iAspNetUser)
        {
            _iAspNetUser = iAspNetUser;            
        }
        [AcceptVerbs("POST")]
        [HttpPost]
        [Authorize(Roles = AdminConstants.ASPNETUSER_POST_ROLE)]       
        public async Task<HttpResponseMessage> Save(AspNetUserModel data)
        {
            try
            {
              
                await _iAspNetUser.SaveAsync(data);
               
            }
            catch (Exception ex)
            {
                Common.MyLogger.Error(ex.Message + ex.StackTrace + ex.InnerException.ToString());
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Error");
            }
            return Request.CreateResponse(HttpStatusCode.OK, "Data Saved");
        }
    }
}