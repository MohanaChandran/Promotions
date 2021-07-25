using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Propmotions.Core
{
    public class KeywordDocumentMapping : BaseEntity
    {
        [Required]
        public int DocumentId { get; set; }
        
        [Required]
        public int KeywordId { get; set; }
        public virtual Keyword Keyword { get; set; }   
        public virtual Document Document { get; set; }
    }
}
