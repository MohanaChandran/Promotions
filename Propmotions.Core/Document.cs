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
        public string URL { get; set; }
        public string Name { get; set; }       
        public virtual ICollection<KeywordDocumentMapping> DocumemtMappings { get; set; }
    }
}
