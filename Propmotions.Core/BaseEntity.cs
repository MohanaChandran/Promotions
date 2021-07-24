using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Propmotions.Core
{
    public class BaseEntity
    {

        public int Id { get; set; }

        private DateTime _createdDate;
        private DateTime _modifiedDate;

        /// <summary>
        /// CreatedBy 
        /// </summary>       
        public int CreatedBy { get; set; }

      
        /// <summary>
        /// CreatedDate 
        /// </summary>       
        public DateTime CreatedDate
        {
            get { return _createdDate != DateTime.MinValue ? _createdDate : DateTime.UtcNow; }
            set { _createdDate = value; }
        }


        /// <summary>
        /// ModifiedDate 
        /// </summary>       
        public DateTime ModifiedDate
        {
            get { return _modifiedDate != DateTime.MinValue ? _modifiedDate : DateTime.UtcNow; }
            set { _modifiedDate = value; }
        }
    }
}
