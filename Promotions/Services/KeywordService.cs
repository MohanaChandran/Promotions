using AutoMapper;
using Promotion.Models;
using Propmotions.Core.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Promotion.Services
{
    public class KeywordService : IKeywordService
    {

        private readonly IRepository _repository;
        private readonly IMapper _mapper;
        public KeywordService(IRepository repository
            , IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<Keyword> CreateKeyword(Keyword keyWord)
        {
            var keyword = await _repository.Add<Propmotions.Core.Keyword>(
                _mapper.Map<Propmotions.Core.Keyword>(keyWord));

            return _mapper.Map<Keyword>(keyword);
        }

        public async Task DeleteKeyword(int id)
        {
            await _repository.Delete<Propmotions.Core.Keyword>(id);           
        }

        public async Task<ICollection<Keyword>> GetKeywords(string keywordName)
        {
            var keywords = await _repository.GetAll<Propmotions.Core.Keyword>(
                (t) => t.Name.ToLower().StartsWith(keywordName.ToLower()));

            return _mapper.Map<ICollection<Keyword>>(keywords);
        }

        public async Task<Keyword> GetKeywordById(int id)
        {
            var keyword = await _repository.GetById<Propmotions.Core.Keyword>(id, "DocumemtMappings");

            return _mapper.Map<Keyword>(keyword);
        }

        public async Task<Keyword> UpdateKeyword(Keyword keyWord)
        {   
            var keyword = await  _repository.Update<Propmotions.Core.Keyword>(
                _mapper.Map<Propmotions.Core.Keyword>(keyWord), new string[] { "DocumemtMappings" });

            return _mapper.Map<Keyword>(keyword);

        }
    }
}
