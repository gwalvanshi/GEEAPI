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
    public class MasterTableController:BaseController
    {
        IMasterTable _iMasterTable;
        public MasterTableController(IMasterTable iMasterTable)
        {
            _iMasterTable = iMasterTable;
        }

        [AcceptVerbs("GET")]
        [HttpGet]
        [Authorize(Roles = AdminConstants.MASTERTABLE_GET_ROLE)]
        [Route("api/MasterTable/GetAll/{masterTableId=masterTableId}/{masterTypeId=masterTypeId}/{schoolId=schoolId}/{groupId=groupId}/{sessionYear=sessionYear}/{isDeleted=isDeleted}")]
        public JsonResult<List<MasterTableModel>> GetAll(int? masterTableId, int? masterTypeId, int? schoolId, int? groupId, int? sessionYear, bool? isDeleted)
        {
            try
            {
                var objList = _iMasterTable.GetMasterData(masterTableId, masterTypeId, schoolId, groupId, sessionYear, isDeleted);
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