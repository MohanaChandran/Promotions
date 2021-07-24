using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Threading.Tasks;
using Exceptions;
using Logger;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Promotion.Models;
using Promotion.Response;

namespace Promotion.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class BaseController : Controller
    {

     
        readonly IConfiguration _configuration;
        //private readonly LocalizationHelper _localizationHelper;
        protected readonly ILogger _logger;
      

        public BaseController(
              IConfiguration configuration
            , ILogger logger)
        {
         
            _configuration = configuration;
            //_localizationHelper = new LocalizationHelper(this);
            _logger = logger;           
        }


        [Route("ping")]
        [HttpGet]
        public async Task<DateTime> Ping()
        {
            return await Task.FromResult<DateTime>(DateTime.Now);
        }

        /// <summary>
        /// HandleExcpetion
        /// </summary>
        /// <param name="ex"></param>
        /// <returns></returns>
        protected async Task<IActionResult> HandleExcpetion(Exception ex)
        {

            _logger.Log(ex);

            ObjectResult result = null;

            var errorResponse = GetErrorResponse<bool>(ex);

            if (ex is UnauthorizedAccessException)
                result = Unauthorized(errorResponse);
           
            else
                result = UnprocessableEntity(errorResponse);

            return await Task.FromResult(result);
        }

        private BaseResponse<T> GetErrorResponse<T>(Exception ex)
        {
            var message = (ex is BaseException) ?  ex.Message : "";
               //Mohan - Change this
               //string.IsNullOrEmpty(_localizationHelper.GetLocalizedMessage(((BaseException)ex).ErrorCode))
              // : _localizationHelper.GetLocalizedMessage(((BaseException)ex).ErrorCode)
               

            return new BaseResponse<T>()
            {
                ErrorDetails = new ErrorDetails()
                {
                    ErrorCode =
              (ex is BaseException) ? ((BaseException)ex).ErrorCode : "NA",
                    ErrorMessage = message
                }
            };
        }


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private InstanceDetails ValidateAndGetInstanceDetails()
        {
            var requestHeaders = HttpContext.Request.Headers;
            try
            {
                return new InstanceDetails()
                {
                    APIKey = requestHeaders["X-API-KEY"],
                    ServerVersion = requestHeaders["ServerVersion"],
                    ClientVersion = requestHeaders["ClientVersion"],
                    RegionId = Guid.Parse(requestHeaders["RegionId"]),
                    CorrelationId = Guid.Parse(requestHeaders["CorrelationId"])
                };
            }
            catch
            {
                throw new ValidationException("Error validating request headers. Ensure that you pass the correct data type for the headers");
            }
        }

        /// <summary>
        /// ValidateModelState
        /// </summary>
        protected void ValidateModelState<T>(T model) where T : BaseModel
        {
            if (!ModelState.IsValid)
            {
                throw new ModelValidationException(ModelState);
            }

            UpdateInstanceDetails<BaseModel>(model.GetType(), model, ValidateAndGetInstanceDetails());
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="requestHeaders"></param>
        /// <returns></returns>
        protected InstanceDetails ValidateAndGetInstanceDetails(IHeaderDictionary requestHeaders)
        {
            try
            {
                return new InstanceDetails()
                {
                    APIKey = requestHeaders["X-API-KEY"],
                    ServerVersion = requestHeaders["ServerVersion"],
                    ClientVersion = requestHeaders["ClientVersion"],
                    RegionId = Guid.Parse(requestHeaders["RegionId"]),
                    CorrelationId = Guid.Parse(requestHeaders["CorrelationId"])
                };
            }
            catch
            {
                throw new ValidationException("Error validating request headers. Ensure that you pass the correct data type for the headers");
            }
        }

        /// <summary>
        /// Loop through all properties and assign the Instance Details
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="classType"></param>
        /// <param name="instance"></param>
        /// <param name="instanceDetails"></param>
        private void UpdateInstanceDetails<T>(Type classType, T instance, InstanceDetails instanceDetails) where T : BaseModel
        {
            try
            {
                ((BaseModel)instance).InstanceDetails = instanceDetails;
            }
            catch
            {
                //Mohan Log exception here!!
            }

        }

    }
}
