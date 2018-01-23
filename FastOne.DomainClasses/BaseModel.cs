using System;
namespace FastOne.DomainClasses.Models
{
    public class BaseModel
    {

        public bool IsActive { get; set; }

        public long CreatedBy { get; set; }

        public DateTime CreateDate { get; set; }
    }
}
