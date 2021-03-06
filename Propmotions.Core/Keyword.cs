using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Propmotions.Core
{
    public class Keyword : BaseEntity
    {       
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual ICollection<KeywordDocumentMapping> DocumemtMappings { get; set; }
    }
}
