using Promotion.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Promotion.Services
{
    public interface IKeywordService
    {
        Task<Keyword> CreateKeyword(Keyword keyWord);
        Task DeleteKeyword(int id);
        Task<ICollection<Keyword>> GetKeywords(string keywordName);
        Task<Keyword> UpdateKeyword(Keyword keyWord);
        Task<Keyword> GetKeywordById(int id);
    }
}
