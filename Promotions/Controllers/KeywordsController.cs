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
    public class KeywordsController : BaseController
    {
        private readonly IKeywordService _keywordService;

        public KeywordsController(IKeywordService keywordService                           
                , ILogger logger) : base(
                 logger)
        {
            _keywordService = keywordService;
        }



        /// <summary>
        /// GetKeywords
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType(typeof(BaseResponse<Keyword[]>), 401)]
        [ProducesResponseType(typeof(BaseResponse<bool>), 404)]
        public async Task<IActionResult> Get([FromQuery] string name)
        {
            try
            {
                return Ok(
                    await _keywordService.GetKeywords(string.IsNullOrWhiteSpace(name) ? "" : name.Trim())
                    );
            }
            catch (Exception ex)
            {
                return await base.HandleExcpetion(ex);
            }
        }



        /// <summary>
        /// GetKeywordById
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(BaseResponse<Keyword[]>), 401)]
        [ProducesResponseType(typeof(BaseResponse<bool>), 404)]
        public async Task<IActionResult> Get([FromRoute] int id)
        {
            try
            {
                return Ok(
                    await _keywordService.GetKeywordById(id)
                    );
            }
            catch (Exception ex)
            {
                return await base.HandleExcpetion(ex);
            }
        }


        /// <summary>
        /// CreateKeyword
        /// </summary>
        /// <param name="keyWord"></param>
        /// <returns></returns>
        [HttpPost]
        [ProducesResponseType(typeof(BaseResponse<Keyword>), 200)]
        [ProducesResponseType(typeof(BaseResponse<bool>), 401)]
        [ProducesResponseType(typeof(BaseResponse<bool>), 400)]
        public async Task<IActionResult> Create(Keyword keyWord)
        {
            try
            {
                ValidateModelState<Keyword>(keyWord);     
                
                return Ok(
                     await _keywordService.CreateKeyword(keyWord)
                     );
            }
            catch (Exception ex)
            {
                return await base.HandleExcpetion(ex);
            }
        }



        /// <summary>
        /// UpdateKeyword
        /// </summary>
        /// <param name="keyWord"></param>
        /// <returns></returns>
        [HttpPut]
        [ProducesResponseType(typeof(BaseResponse<Keyword>), 200)]
        [ProducesResponseType(typeof(BaseResponse<bool>), 401)]
        [ProducesResponseType(typeof(BaseResponse<bool>), 400)]
        public async Task<IActionResult> Update(Keyword keyWord)
        {
            try
            {
                ValidateModelState<Keyword>(keyWord);
                
                return Ok(
                    await _keywordService.UpdateKeyword(keyWord)
                    );
            }
            catch (Exception ex)
            {
                return await base.HandleExcpetion(ex);
            }
        }



        /// <summary>
        /// DeleteKeyword
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]        
        [ProducesResponseType(typeof(BaseResponse<bool>), 401)]
        [ProducesResponseType(typeof(BaseResponse<bool>), 404)]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                await _keywordService.DeleteKeyword(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return await base.HandleExcpetion(ex);
            }
        }
    }
}
