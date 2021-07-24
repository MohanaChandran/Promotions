using Promotion.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Promotion.Services
{
    public interface IDocumentService
    {
        Task<ICollection<Document>> GetDocuments();
    }
}
