﻿using AutoMapper;
using GEE.Business.Interface.Admission;
using GEE.Business.Models.Admission;
using GEE.DataAccess;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System.Linq.Expressions;
using System.Data.Entity;

namespace GEE.Business.Manager.Admission
{
    public class EnquiryManager : IEnquiry
    {
        IMyDataAccess<Enquiry> _enquiryDataAccess = new MyDataAccess<Enquiry>();
      
        public EnquiryModel Save(EnquiryModel entity)
        {
            var enquiry = _enquiryDataAccess.Save(Mapper.Map<Enquiry>(entity));
            return new EnquiryModel { Enquiry_ID = enquiry.Enquiry_ID };
        }

        public async Task<EnquiryModel> SaveAsync(EnquiryModel entity)
        {
            var enquiry = await _enquiryDataAccess.SaveAsync(Mapper.Map<Enquiry>(entity));
            return new EnquiryModel { Enquiry_ID = enquiry.Enquiry_ID };
        }

        public void Delete(EnquiryModel entity)
        {
            _enquiryDataAccess.Delete(entity.Enquiry_ID);
        }

        public async Task DeleteAsync(EnquiryModel entity)
        {
            await _enquiryDataAccess.DeleteAsync(entity.Enquiry_ID);
        }

        public List<EnquiryModel> GetAll()
        {
            try
            {
                //var ddllist = _enquiryDataAccess.GetDDl("Religion", "ReligionName", "Religion_ID", "ISDeleted=0");

                var enquiryList = _enquiryDataAccess.GetAll();              
                List <EnquiryModel> enquiryModelList = new List<EnquiryModel>();
                foreach (var item in enquiryList)
                {
                    enquiryModelList.Add(Mapper.Map<EnquiryModel>(item));
                }
                return enquiryModelList;
            }
            catch (Exception ex)
            {
                string str = ex.ToString();
                
            }
            return null;
        }
        public List<EnquiryModel> GetEnq()
        {
            List<EnquiryModel> mydict = new List<EnquiryModel>();
            var enquiryList = _enquiryDataAccess.GetAll();
            foreach (var item in enquiryList)
            {
                EnquiryModel obj = new EnquiryModel { Enquiry_ID = item.Enquiry_ID, EnquiryNo = item.EnquiryNo };
                mydict.Add(obj);
            }
            return mydict;

            // add an item
            
        }
      
        //public Dictionary<int, string>  GetEnq1()
        //{

        //    Dictionary<int, string> mydict = new Dictionary<int, string>();
        //    var enquiryList = _enquiryDataAccess.GetAll();
        //    foreach (var item in enquiryList)
        //    {
        //        mydict.Add(item.Enquiry_ID, item.EnquiryNo);
        //    }
        //    return mydict;

        //    // add an item

        //}

        public async Task<List<EnquiryModel>> GetAllAsync()
        {
            var enquiryList = await _enquiryDataAccess.GetAllAsync();
            List<EnquiryModel> enquiryModelList = new List<EnquiryModel>();
            foreach (var item in enquiryList)
            {
                enquiryModelList.Add(Mapper.Map<EnquiryModel>(item));

            }
            return enquiryModelList;
        }

        public async Task<EnquiryModel> GetByIdAsync(int id)
        {
            return Mapper.Map<EnquiryModel>(await _enquiryDataAccess.GetByIdAsync(id));
        }

        public EnquiryModel GetById(int id)
        {
            var enquiry = _enquiryDataAccess.GetById(id);
            return Mapper.Map<EnquiryModel>(enquiry);
        }

        public EnquiryModel Update(EnquiryModel entity)
        {
            var enquiry = _enquiryDataAccess.Update(Mapper.Map<Enquiry>(entity));
            return new EnquiryModel { Enquiry_ID = enquiry.Enquiry_ID };
        }

        public async Task<EnquiryModel> UpdateAsync(EnquiryModel entity)
        {
            var enquiry = await _enquiryDataAccess.UpdateAsync(Mapper.Map<Enquiry>(entity));
            return new EnquiryModel { Enquiry_ID = enquiry.Enquiry_ID };
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
        // ~EnquiryManager() {
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

        public List<EnquiryModel> GetAll(string firstName,string lastName)
        {
            try
            {
                
                var enquiryList = _enquiryDataAccess.GetAll(e=>e.EnquiryNo=="0");
                List<EnquiryModel> enquiryModelList = new List<EnquiryModel>();
                foreach (var item in enquiryList)
                {
                    enquiryModelList.Add(Mapper.Map<EnquiryModel>(item));
                }
                return enquiryModelList;
            }
            catch (Exception ex)
            {
                string str = ex.ToString();

            }
            return null;
        }



        #endregion

    }
}
