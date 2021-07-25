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

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        [MaxLength(500)]
        public string URL { get; set; }
        public virtual ICollection<KeywordDocumentMapping> DocumemtMappings { get; set; }
    }
}
