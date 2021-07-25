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
                return createdDate == DateTime.MinValue ? DateTime.UtcNow
                    : TimeZoneInfo.ConvertTimeFromUtc(createdDate,
                    TimeZoneInfo.FindSystemTimeZoneById("India Standard Time"));
            }
            set { createdDate = value; }
        }

        public DateTime ModifiedDate
        {
            internal get
            {
                return modifiedDate == DateTime.MinValue ? DateTime.UtcNow
                      : TimeZoneInfo.ConvertTimeFromUtc(modifiedDate,
                      TimeZoneInfo.FindSystemTimeZoneById("India Standard Time"));
            }
            set { modifiedDate = value; }
        }      
             
        public int CreatedBy { get; set; }

        public InstanceDetails InstanceDetails { get; set; }

        private DateTime modifiedDate { get; set; }

        private DateTime createdDate { get; set; }


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
