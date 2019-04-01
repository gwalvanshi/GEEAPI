using AutoMapper;
using GEE.Business.Interface.DocumentLibrary;
using GEE.Business.Models.DocumentLibrary;
using GEE.DataAccess;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace GEE.Business.Manager.DocumentLibrary
{
    public class DocumentCategoryManager : IDocumentCategory
    {
        IMyDataAccess<DocumentCategory> _documentCategoryDataAccess = new MyDataAccess<DocumentCategory>();

        public void Delete(DocumentCategoryModel entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(DocumentCategoryModel entity)
        {
            throw new NotImplementedException();
        }

        public List<DocumentCategoryModel> GetAll()
        {
            var documentSubList =  _documentCategoryDataAccess.GetAll();
            List<DocumentCategoryModel> documentSubModelList = new List<DocumentCategoryModel>();
            foreach (var item in documentSubList)
            {
                documentSubModelList.Add(Mapper.Map<DocumentCategoryModel>(item));

            }
            return documentSubModelList;
        }

        public async Task<List<DocumentCategoryModel>> GetAllAsync()
        {
            var documentSubList = await _documentCategoryDataAccess.GetAllAsync();
            List<DocumentCategoryModel> documentSubModelList = new List<DocumentCategoryModel>();
            foreach (var item in documentSubList)
            {
                documentSubModelList.Add(Mapper.Map<DocumentCategoryModel>(item));

            }
            return documentSubModelList;
        }

        public DocumentCategoryModel GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<DocumentCategoryModel> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public DocumentCategoryModel Save(DocumentCategoryModel entity)
        {
            throw new NotImplementedException();
        }

        public Task<DocumentCategoryModel> SaveAsync(DocumentCategoryModel entity)
        {
            throw new NotImplementedException();
        }

        public DocumentCategoryModel Update(DocumentCategoryModel entity)
        {
            throw new NotImplementedException();
        }

        public Task<DocumentCategoryModel> UpdateAsync(DocumentCategoryModel entity)
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
        // ~DocumentCategoryManager() {
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
