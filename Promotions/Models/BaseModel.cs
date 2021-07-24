using System;
using System.Text.Json.Serialization;

namespace Promotion.Models
{
    public class BaseModel
    {
        public int Id { get; set; }

        public DateTime CreatedDate
        {
            get
            {
                return _createdDate == DateTime.MinValue ? DateTime.UtcNow
                    : TimeZoneInfo.ConvertTimeFromUtc(_createdDate,
                    TimeZoneInfo.FindSystemTimeZoneById("India Standard Time"));
            }
            set { _createdDate = value; }
        }

        public DateTime ModifiedDate
        {
            internal get
            {
                return _modifiedDate == DateTime.MinValue ? DateTime.UtcNow
                      : TimeZoneInfo.ConvertTimeFromUtc(_modifiedDate,
                      TimeZoneInfo.FindSystemTimeZoneById("India Standard Time"));
            }
            set { _modifiedDate = value; }
        }      
             
        public int CreatedBy { get; set; }

        public InstanceDetails InstanceDetails { get; set; }

        private DateTime _modifiedDate { get; set; }

        private DateTime _createdDate { get; set; }


    }

    public class InstanceDetails
    {
        public string APIKey { get; set; }
        public string ServerVersion { get; set; }
        public string ClientVersion { get; set; }
        public Guid RegionId { get; set; }
        public Guid CorrelationId { get; set; }
    }
}
