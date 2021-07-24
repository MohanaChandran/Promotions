using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Promotion.Models
{
    public class Keyword : BaseModel
    {
        public string Name { get; set; }        
        public virtual ICollection<KeywordDocumentMapping> DocumemtMappings { get; set; }
    }
}
