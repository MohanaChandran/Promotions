using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Promotion.Models
{
    public partial class Document : BaseModel
    {
        public Document()
        {
        }      
      
        public string Name { get; set; }
        public string URL { get; set; }
        public virtual ICollection<KeywordDocumentMapping> DocumemtMappings { get; set; }
    }
}
