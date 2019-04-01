using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GEE.DataAccess;
using GEE.Business.Interface.Admin;
using GEE.Business.Model.Admin;
using AutoMapper;

using GEE.Business.Interface;
using System.Data.SqlClient;
using GEE.Business.Model.Security;

namespace GEE.Business.Manager.Admin
{
    public class MasterTableManager : IMasterTable
    {
        public void Delete(AspNetUserModel entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(AspNetUserModel entity)
        {
            throw new NotImplementedException();
        }

        public List<AspNetUserModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<List<AspNetUserModel>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public AspNetUserModel GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<AspNetUserModel> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public AspNetUserModel Save(AspNetUserModel entity)
        {
            throw new NotImplementedException();
        }

        public Task<AspNetUserModel> SaveAsync(AspNetUserModel entity)
        {
            throw new NotImplementedException();
        }

        public AspNetUserModel Update(AspNetUserModel entity)
        {
            throw new NotImplementedException();
        }

        public Task<AspNetUserModel> UpdateAsync(AspNetUserModel entity)
        {
            throw new NotImplementedException();
        }

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~MasterTableManager() {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }

        public List<MasterTableModel> GetMasterData(int ? masterTableId,int? masterTypeId, int? schoolId, int? groupId, int? sessionYear, bool? isDeleted)
        {
            List<MasterTableModel> getMasterTableModelList = new List<MasterTableModel>();
            try
            {
                using (GEEDbContext context = new GEEDbContext())
                {
                    var P1 = masterTableId != null ? new SqlParameter("@MasterTableId", masterTableId) : new SqlParameter("@MasterTableId", DBNull.Value);
                    var P2 = masterTypeId != null ? new SqlParameter("@MasterTypeId", masterTypeId): new SqlParameter("@MasterTypeId", DBNull.Value);
                    var P3 = schoolId != null ? new SqlParameter("@SchoolId", schoolId) : new SqlParameter("@SchoolId", DBNull.Value);
                    var P4 = groupId != null ? new SqlParameter("@GroupId", groupId) : new SqlParameter("@GroupId", DBNull.Value);
                    var P5 = sessionYear != null ? new SqlParameter("@SessionYear", sessionYear) : new SqlParameter("@SessionYear", DBNull.Value);
                    var P6 = isDeleted != null ? new SqlParameter("@IsDeleted", isDeleted) : new SqlParameter("@IsDeleted", DBNull.Value);

                    getMasterTableModelList = context.Database.SqlQuery<MasterTableModel>("GetMasterTableRecord @MasterTableId, @MasterTypeId,@SchoolId,@GroupId,@SessionYear,@IsDeleted", P1,P2,P3,P4,P5,P6).ToList();
                }

            }
            catch (Exception ex)
            {
                string str = ex.ToString();

            }
            return getMasterTableModelList;
        }
        #endregion
    }
}
