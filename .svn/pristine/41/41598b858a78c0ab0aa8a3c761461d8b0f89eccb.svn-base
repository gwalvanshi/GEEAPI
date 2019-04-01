using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GEE.Business.Interface.Security;
using GEE.Business.Model.Security;
using GEE.DataAccess;

namespace GEE.Business.Manager.Security
{
    public class NavigationPermissionManager : INavigationPermission
    {
       /// <summary>
       /// This method is used for get user permission to user.
       /// </summary>
       /// <param name="userID"></param>
       /// <param name="menuId"></param>
       /// <returns></returns>
        public List<NavigationPermissionModel> GetNavigationPermission(int  userGroupId, int menuId)
        {
            List<NavigationPermissionModel> getNavigationPermissionModelList = new List<NavigationPermissionModel>();
            try
            {
                using (GEEDbContext context = new GEEDbContext())
                {
                    var UId = new SqlParameter("@UserGroupID", userGroupId);
                    var MId = new SqlParameter("@NavigationId", menuId);

                    getNavigationPermissionModelList = context.Database.SqlQuery<NavigationPermissionModel>("GetNavigationPermission @UserGroupID, @NavigationId", UId, MId).ToList();
                }

            }
            catch (Exception ex)
            {
                string str = ex.ToString();

            }
            return getNavigationPermissionModelList;
        }
    }
}
