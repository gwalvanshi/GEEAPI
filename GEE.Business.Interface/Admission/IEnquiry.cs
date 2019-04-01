using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using GEE.Business.Models.Admission;

namespace GEE.Business.Interface.Admission
{
   public interface IEnquiry : IService<EnquiryModel>
    {

        List<EnquiryModel> GetEnq();

        List<EnquiryModel> GetAll(string firstName, string lastName);
    }
}
