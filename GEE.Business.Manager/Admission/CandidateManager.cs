using AutoMapper;
using GEE.Business.Interface.Admission;
using GEE.Business.Models.Admission;
using GEE.DataAccess;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GEE.Business.Manager.Admission
{
    public class CandidateManager : ICandidateDetail
    {
        IMyDataAccess<CandidateDetail> _CandidateDetailDataAccess = new MyDataAccess<CandidateDetail>();

        public CandidateDetailModel Save(CandidateDetailModel entity)
        {
            var candidatedet = _CandidateDetailDataAccess.Save(Mapper.Map<CandidateDetail>(entity));
            return new CandidateDetailModel { CandidateDetail_ID = candidatedet.CandidateDetail_ID };
        }

        public async Task<CandidateDetailModel> SaveAsync(CandidateDetailModel entity)
        {
            var candidatedet = await _CandidateDetailDataAccess.SaveAsync(Mapper.Map<CandidateDetail>(entity));
            return new CandidateDetailModel { CandidateDetail_ID = candidatedet.CandidateDetail_ID };
        }

        public void Delete(CandidateDetailModel entity)
        {
            _CandidateDetailDataAccess.Delete(entity.CandidateDetail_ID);
        }

        public async Task DeleteAsync(CandidateDetailModel entity)
        {
            await _CandidateDetailDataAccess.DeleteAsync(entity.CandidateDetail_ID);
        }

        public List<CandidateDetailModel> GetAll()
        {
            try
            {
                var candidatedetList = _CandidateDetailDataAccess.GetAll();
                List<CandidateDetailModel> candidatedetListModelList = new List<CandidateDetailModel>();
                foreach (var item in candidatedetList)
                {
                    candidatedetListModelList.Add(Mapper.Map<CandidateDetailModel>(item));
                }
                return candidatedetListModelList;
            }
            catch (Exception ex)
            {
                string str = ex.ToString();
                
            }
            return null;
        }

        public async Task<List<CandidateDetailModel>> GetAllAsync()
        {
            var candidatedetList = await _CandidateDetailDataAccess.GetAllAsync();
            List<CandidateDetailModel> candidatedeModelList = new List<CandidateDetailModel>();
            foreach (var item in candidatedetList)
            {
                candidatedeModelList.Add(Mapper.Map<CandidateDetailModel>(item));

            }
            return candidatedeModelList;
        }

        public async Task<CandidateDetailModel> GetByIdAsync(int id)
        {
            return Mapper.Map<CandidateDetailModel>(await _CandidateDetailDataAccess.GetByIdAsync(id));
        }

        public CandidateDetailModel GetById(int id)
        {
            var candidatede = _CandidateDetailDataAccess.GetById(id);
            return Mapper.Map<CandidateDetailModel>(candidatede);
        }

        public CandidateDetailModel Update(CandidateDetailModel entity)
        {
            var candidatede = _CandidateDetailDataAccess.Update(Mapper.Map<CandidateDetail>(entity));
            return new CandidateDetailModel { CandidateDetail_ID = candidatede.CandidateDetail_ID };
        }

        public async Task<CandidateDetailModel> UpdateAsync(CandidateDetailModel entity)
        {
            var candidatede = await _CandidateDetailDataAccess.UpdateAsync(Mapper.Map<CandidateDetail>(entity));
            return new CandidateDetailModel { CandidateDetail_ID = candidatede.CandidateDetail_ID };
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
        // ~candidatedeManager() {
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

        #endregion

    }
}
