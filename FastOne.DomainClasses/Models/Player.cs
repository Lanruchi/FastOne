using System.ComponentModel.DataAnnotations;
namespace FastOne.DomainClasses.Models
{
    public class Player : BaseModel
    {
        public long PlayerId { get; set; }

        public string UserName { get; set; }

        public string Password_Hash { get; set; }

        public string EmailAddress { get; set; }

        public long PhoneNumber { get; set; }
    }
}
