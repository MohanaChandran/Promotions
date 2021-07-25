using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Promotion.Models
{
    public class KeywordDocumentMapping : BaseModel
    {
        [Required]
        public int DocumentId { get; set; }      
        public int KeywordId { get; set; }
        public virtual Keyword Keyword { get; set; }
        public virtual Document Document { get; set; }
    }
}
