using AutoMapper;
using GEE.Business.Interface.DocumentLibrary;
using GEE.Business.Models.DocumentLibrary;
using GEE.DataAccess;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GEE.Business.Manager.DocumentLibrary
{
   public class DocumentSubmissionManager:IDocumentSubmission
    {
        IMyDataAccess<DocumentSubmissionDetail> _documentSubDataAccess = new MyDataAccess<DocumentSubmissionDetail>();

        public void Delete(DocumentSubmissionModel entity)
        {
            _documentSubDataAccess.Delete(entity.DocumentSubmission_ID);
        }

        public async Task DeleteAsync(DocumentSubmissionModel entity)
        {
           await _documentSubDataAccess.DeleteAsync(entity.DocumentSubmission_ID);
        }

        public List<DocumentSubmissionModel> GetAll()
        {
            var documentSubList =  _documentSubDataAccess.GetAll();
            List<DocumentSubmissionModel> documentSubModelList = new List<DocumentSubmissionModel>();
            foreach (var item in documentSubList)
            {
                documentSubModelList.Add(Mapper.Map<DocumentSubmissionModel>(item));

            }
            return documentSubModelList;
        }

        public  async Task<List<DocumentSubmissionModel>> GetAllAsync()
        {
            var documentSubList = await _documentSubDataAccess.GetAllAsync();
            List<DocumentSubmissionModel> documentSubModelList = new List<DocumentSubmissionModel>();
            foreach (var item in documentSubList)
            {
                documentSubModelList.Add(Mapper.Map<DocumentSubmissionModel>(item));

            }
            return documentSubModelList;
        }

        public DocumentSubmissionModel GetById(int id)
        {
            return Mapper.Map<DocumentSubmissionModel>(_documentSubDataAccess.GetById(id));
        }

        public async Task<DocumentSubmissionModel> GetByIdAsync(int id)
        {
            return Mapper.Map<DocumentSubmissionModel>(await  _documentSubDataAccess.GetByIdAsync(id));
        }

        public DocumentSubmissionModel Save(DocumentSubmissionModel entity)
        {
            var documentSub =  _documentSubDataAccess.Save(Mapper.Map<DocumentSubmissionDetail>(entity));
            return new DocumentSubmissionModel { DocumentSubmission_ID = documentSub.DocumentSubmission_ID };
        }

        public async Task<DocumentSubmissionModel> SaveAsync(DocumentSubmissionModel entity)
        {
            var documentSub = await _documentSubDataAccess.SaveAsync(Mapper.Map<DocumentSubmissionDetail>(entity));
            return new DocumentSubmissionModel { DocumentSubmission_ID = documentSub.DocumentSubmission_ID };
        }

        public DocumentSubmissionModel Update(DocumentSubmissionModel entity)
        {
            var documentSub = _documentSubDataAccess.Update(Mapper.Map<DocumentSubmissionDetail>(entity));
            return new DocumentSubmissionModel { DocumentSubmission_ID = documentSub.DocumentSubmission_ID };
        }

        public async Task<DocumentSubmissionModel> UpdateAsync(DocumentSubmissionModel entity)
        {
            var documentSub = await _documentSubDataAccess.UpdateAsync(Mapper.Map<DocumentSubmissionDetail>(entity));
            return new DocumentSubmissionModel { DocumentSubmission_ID = documentSub.DocumentSubmission_ID };
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
        // ~DocumentSubmissionManager() {
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
