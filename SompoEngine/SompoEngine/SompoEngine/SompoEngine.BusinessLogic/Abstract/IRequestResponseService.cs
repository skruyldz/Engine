using SompoEngine.Common.BaseTypes.Abstract;
using SompoEngine.Entites;
using SompoEngine.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SompoEngine.BusinessLogic.Abstract
{
    public interface IRequestResponseService
    {
        Task<IDataResult<ServiceResponse>> SendServiceCall(ServiceCall request);
        Task<IDataResult<IList<ServiceRequestResponse>>> GetAllServiceCall();
        Task<IDataResult<string>> GetRequestJson(int Id);
        Task<IDataResult<string>> GetResponseJson(int Id);

    }
}
