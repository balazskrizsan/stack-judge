using System.ComponentModel.DataAnnotations;
using System.Configuration;

namespace StackJudge.Requests
{
    public class CompanyPostRequest
    {
        [Required(ErrorMessage = "Please provide `name`.")]
        [MinLength(2, ErrorMessage = "Minimum length of `name` is 2.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please provide `company size`.")]
        [Range(1, 5, ErrorMessage = "Bad `company size` selected.")]
        public int CompanySizeId { get; set; }

        // [Required(ErrorMessage = "Please provide `it size`.")]
        // [Range(1, 5, ErrorMessage = "Bad `it size` selected.")]
        public int ItSizeId { get; set; }
    }
}
