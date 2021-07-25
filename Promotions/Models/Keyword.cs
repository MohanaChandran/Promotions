using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Promotion.Models
{
    public class Keyword : BaseModel
    {
        public string Description { get; set; }
        
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }        
        public virtual ICollection<KeywordDocumentMapping> DocumemtMappings { get; set; }
    }
}
