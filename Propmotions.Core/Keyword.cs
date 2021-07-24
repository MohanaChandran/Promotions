using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Propmotions.Core
{
    public class Keyword : BaseEntity
    {       
        public string Name { get; set; }
        public virtual ICollection<KeywordDocumentMapping> DocumemtMappings { get; set; }
    }
}
