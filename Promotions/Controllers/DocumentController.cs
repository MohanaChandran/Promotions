using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Logger;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Promotion.Models;
using Promotion.Response;
using Promotion.Services;

namespace Promotion.Controllers
{

    /// <summary>
    /// DocumentController
    /// </summary>
    public class DocumentController : BaseController
    {
        private readonly IDocumentService _documentService;
        
        public DocumentController(IDocumentService documentService             
                , ILogger logger) : base(
                 logger)
        {
            _documentService = documentService;            
        }



        /// <summary>
        /// Get All Documents
        /// </summary>
        /// <returns></returns>
        [HttpGet]        
        [ProducesResponseType(typeof(BaseResponse<Keyword[]>), 401)]
        [ProducesResponseType(typeof(BaseResponse<bool>), 404)]
        public async Task<IActionResult> Get()
        {
            try
            {
                return Ok(
                    await _documentService.GetDocuments()
                );
            }
            catch (Exception ex)
            {
                return await base.HandleExcpetion(ex);
            }
        }
    }
}
