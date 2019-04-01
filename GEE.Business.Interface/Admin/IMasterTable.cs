using GEE.Business.Model.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEE.Business.Interface.Admin
{
   public interface IMasterTable : IService<AspNetUserModel>
    {
        List<MasterTableModel> GetMasterData(int ? masterTableId,int ? masterTypeId,int ? schoolId,int ?groupId, int ? sessionYear, bool ? isDeleted);
    }
}
