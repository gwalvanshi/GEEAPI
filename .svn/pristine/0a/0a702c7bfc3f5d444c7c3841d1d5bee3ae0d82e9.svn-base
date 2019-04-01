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
namespace GEE.Business.Manager.Admin
{
    public class AspNetUserManager : IAspNetUser
    {
        IMyDataAccess<GEE.DataAccess.AspNetUser> _db = new MyDataAccess<GEE.DataAccess.AspNetUser>();
        public void Delete(Model.Admin.AspNetUserModel entity)
        {
            _db.Delete(1);
        }

        public Task DeleteAsync(Model.Admin.AspNetUserModel entity)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public List<Model.Admin.AspNetUserModel> GetAll()
        {
            try
            {
                //var ddllist = _enquiryDataAccess.GetDDl("Religion", "ReligionName", "Religion_ID", "ISDeleted=0");

                var enquiryList = _db.GetAll();
                List<Model.Admin.AspNetUserModel> enquiryModelList = new List<Model.Admin.AspNetUserModel>();
                foreach (var item in enquiryList)
                {
                    enquiryModelList.Add(Mapper.Map<Model.Admin.AspNetUserModel>(item));
                }
                return enquiryModelList;
            }
            catch (Exception ex)
            {
                string str = ex.ToString();

            }
            return null;
        }

        public Task<List<Model.Admin.AspNetUserModel>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Model.Admin.AspNetUserModel GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Model.Admin.AspNetUserModel> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Model.Admin.AspNetUserModel Save(Model.Admin.AspNetUserModel entity)
        {
            var user = _db.Save(Mapper.Map<GEE.DataAccess.AspNetUser>(entity));
            return new Model.Admin.AspNetUserModel { UserName = user.UserName };
        }

        public async Task<Model.Admin.AspNetUserModel> SaveAsync(Model.Admin.AspNetUserModel entity)
        {
            var user = await _db.SaveAsync(Mapper.Map<GEE.DataAccess.AspNetUser>(entity));
            return new Model.Admin.AspNetUserModel { UserName = user.UserName };
        }

        public Model.Admin.AspNetUserModel Update(Model.Admin.AspNetUserModel entity)
        {
            throw new NotImplementedException();
        }

        public Task<Model.Admin.AspNetUserModel> UpdateAsync(Model.Admin.AspNetUserModel entity)
        {
            throw new NotImplementedException();
        }
    }
}
