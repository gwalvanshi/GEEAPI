using AutoMapper;
using GEE.Business.Interface.DocumentLibrary;
using GEE.Business.Models.DocumentLibrary;
using GEE.DataAccess;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GEE.Business.Manager.DocumentLibrary
{
    public class DocumentTypeManager : IDocumentType
    {
        IMyDataAccess<DocumentType> _documentTypeDataAccess = new MyDataAccess<DocumentType>();
        public void Delete(DocumentTypeModel entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(DocumentTypeModel entity)
        {
            throw new NotImplementedException();
        }

        public List<DocumentTypeModel> GetAll()
        {
            var documentSubList = _documentTypeDataAccess.GetAll();
            List<DocumentTypeModel> documentSubModelList = new List<DocumentTypeModel>();
            foreach (var item in documentSubList)
            {
                documentSubModelList.Add(Mapper.Map<DocumentTypeModel>(item));

            }
            return documentSubModelList;
        }

        public async Task<List<DocumentTypeModel>> GetAllAsync()
        {
            var documentSubList =await  _documentTypeDataAccess.GetAllAsync();
            List<DocumentTypeModel> documentSubModelList = new List<DocumentTypeModel>();
            foreach (var item in documentSubList)
            {
                documentSubModelList.Add(Mapper.Map<DocumentTypeModel>(item));

            }
            return documentSubModelList;
        }

        public DocumentTypeModel GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<DocumentTypeModel> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public DocumentTypeModel Save(DocumentTypeModel entity)
        {
            throw new NotImplementedException();
        }

        public Task<DocumentTypeModel> SaveAsync(DocumentTypeModel entity)
        {
            throw new NotImplementedException();
        }

        public DocumentTypeModel Update(DocumentTypeModel entity)
        {
            throw new NotImplementedException();
        }

        public Task<DocumentTypeModel> UpdateAsync(DocumentTypeModel entity)
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
        // ~DocumentTypeManager() {
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
