using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Propmotions.Core
{
    public partial class Document : BaseEntity
    {
        public Document()
        {

        }

        [Required]
        public string URL { get; set; }

        [Required]
        public string Name { get; set; }       
        public virtual ICollection<KeywordDocumentMapping> DocumemtMappings { get; set; }
    }
}
