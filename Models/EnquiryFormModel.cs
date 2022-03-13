using System.ComponentModel.DataAnnotations;

namespace PoWhitePhoto.Models
{
    public class EnquiryFormModel
    {
        [Required(ErrorMessage = "Please provide your name.")]
        [Display(Name = "Full Name")]
        public string FullName { get; set; }
        [Required(ErrorMessage = "Please provide your email address.")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Email { get; set; }
        public string Phone { get; set; }
        [MaxLength(4000)]
        public string Message { get; set; }
        [Required(ErrorMessage = "Please select enquiry type.")]
        [Display(Name = "Enquiry Type")]
        public string EnquiryType { get; set; }
    }
}
