using System;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Customer
    {
        public int Id { get; set; }
        
        [Required( ErrorMessage = "Name required.")]
        [StringLength(255)]
        public string Name { get; set; }
        
        public bool IsSubscribedToNewsletter { get; set; }
        
        public MembershipType MembershipType { get; set; }

        [Display(Name = "Membership Type")]
        [Required(ErrorMessage = "Select membership type.")]
        public byte MembershipTypeId { get; set; }

        [Display(Name = "Date of Birth")]
        [Minimum18YearsIfAMember]
        public DateTime? Birthdate { get; set; }
    }
}