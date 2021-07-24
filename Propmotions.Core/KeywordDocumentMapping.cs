using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Propmotions.Core
{
    public class KeywordDocumentMapping : BaseEntity
    {
        public int DocumentId { get; set; }
        public int KeywordId { get; set; }
        public virtual Keyword Keyword { get; set; }   
        public virtual Document Document { get; set; }
    }
}
