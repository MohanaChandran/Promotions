using AutoMapper;
using Promotion.Models;
using Propmotions.Core.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Promotion.Services
{
    public class DocumentService : IDocumentService
    {
        private readonly IRepository _repository;
        private readonly IMapper _mapper;
        public DocumentService(IRepository repository
            , IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }


        /// <summary>
        /// Get All Documents
        /// </summary>
        /// <returns></returns>
        public async Task<ICollection<Document>> GetDocuments()
        {
            var documents = await _repository.GetAll<Propmotions.Core.Document>();
            return _mapper.Map<ICollection<Document>>(documents);
        }
    }
}
