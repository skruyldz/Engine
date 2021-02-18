using Newtonsoft.Json;
using SompoEngine.BusinessLogic.Abstract;
using SompoEngine.Common.BaseTypes.Abstract;
using SompoEngine.Common.BaseTypes.Implementation;
using SompoEngine.Common.ComplexTypes;
using SompoEngine.Common.EntityEnums;
using SompoEngine.Common.Static;
using SompoEngine.DataAccess.Abstract;
using SompoEngine.Entites;
using SompoEngine.Models;
using SompoEngine.Models.BusinessModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SompoEngine.BusinessLogic.Implementation
{
    public class RequestResponseService : IRequestResponseService
    {
        private readonly IUnitOfWork _unitOfWork;
        public RequestResponseService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IDataResult<IList<ServiceRequestResponse>>> GetAllServiceCall()
        {
            try
            {
                var data = await _unitOfWork.ServiceRequestResponse.ToListAsync();
                if (data != null)
                {
                    return new DataResult<IList<ServiceRequestResponse>>(ResultStatus.Success, data);
                }
                else
                {
                    return new DataResult<IList<ServiceRequestResponse>>(ResultStatus.Info, "Data yok", null);
                }
            }
            catch (Exception ex)
            {
                return new DataResult<IList<ServiceRequestResponse>>(ResultStatus.Error, "Hata", null,new Exception(ex.Message));
            }
        }

        public async Task<IDataResult<string>> GetRequestJson(int Id)
        {
            var data = await _unitOfWork.ServiceRequestResponse.FirtsOrDefaultAsync(x => x.Id == Id);
            return new DataResult<string>(ResultStatus.Success, data.RequestJson);
        }

        public async Task<IDataResult<string>> GetResponseJson(int Id)
        {
            var data = await _unitOfWork.ServiceRequestResponse.FirtsOrDefaultAsync(x => x.Id == Id);
            return new DataResult<string>(ResultStatus.Success, data.ResponseJson);
        }

        public async Task<IDataResult<ServiceResponse>> SendServiceCall(ServiceCall request)
        {
            try
            {
                var serviceResponse = new ServiceResponse();
                var serviceRequest = CreateServiceRequest(request);
                var serializeData = JsonConvert.SerializeObject(serviceRequest);

                //API request atımı
                if (!string.IsNullOrWhiteSpace(serializeData))
                {
                    HttpWebRequest req = HttpWebRequest.Create(StaticStringVariables.APIURL) as HttpWebRequest;
                    req.Method = StaticStringVariables.Method;
                    req.ContentType = StaticStringVariables.ContentType;

                    using (var streamWriter = new StreamWriter(req.GetRequestStream()))
                    {
                        streamWriter.Write(serializeData);
                        streamWriter.Flush();
                        streamWriter.Close();
                    }

                    //API isteğinden sonra değeri setleyelim
                    var dbData = await _unitOfWork.ServiceRequestResponse.AddAsync(new ServiceRequestResponse
                    {
                        EndorsNo = request.EndorsNo,
                        ProposalNo = request.ProposalNo,
                        ProductNo = request.ProductNo,
                        RenewalNo = request.RenewalNo,
                        RequestJson = serializeData,
                        Status = (int)EntityStatus.Active
                    });
                    await _unitOfWork.SaveChangesAsync();

                    //Response Yanıtımızı Manupile Edelim
                    using(HttpWebResponse webResponse = req.GetResponse() as HttpWebResponse)
                    {
                        using (StreamReader reader = new StreamReader(webResponse.GetResponseStream()))
                        {
                            var results = reader.ReadToEnd();
                            dbData.ResponseJson = results;
                            await _unitOfWork.SaveChangesAsync();
                            serviceResponse = JsonConvert.DeserializeObject<ServiceResponse>(results);
                        }
                    }
                    return new DataResult<ServiceResponse>(Common.ComplexTypes.ResultStatus.Success, serviceResponse);
                }
                else
                {
                    return new DataResult<ServiceResponse>(Common.ComplexTypes.ResultStatus.Error,"Servis Çağrımında Hata",null);
                }
            }
            catch (Exception ex)
            {
                return new DataResult<ServiceResponse>(Common.ComplexTypes.ResultStatus.Error, "Exception", null, new Exception(ex.Message));
            }
        }

        #region Private

        private ServiceRequest CreateServiceRequest(ServiceCall request)
        {
            ServiceRequest serviceRequest = new ServiceRequest(); 

            #region authentications

            ServiceRequest.Authentications authentications = new ServiceRequest.Authentications();
            authentications.Key = StaticStringVariables.Key;
            authentications.Source = StaticStringVariables.Source;
            serviceRequest.Authentication = authentications;

            #endregion authentications

            #region objects

            ServiceRequest.Objects objects = new ServiceRequest.Objects();
            objects.EndorsNo = request.EndorsNo;
            objects.ProductNo = request.ProductNo;
            objects.ProposalNo = Convert.ToInt64(request.ProposalNo);
            objects.RenewalNo = request.RenewalNo;
            serviceRequest.Object = objects;

            #endregion objects

            return serviceRequest;
        }

        #endregion
    }
}
