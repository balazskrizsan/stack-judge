using System.ComponentModel.DataAnnotations;
using System.Configuration;

namespace StackJudge.Requests
{
    public class CompanyPostRequest
    {
        [Required(ErrorMessage = "Missing name.")]
        [MinLength(10)]
        public string Name        { get; set; }
        [Required(ErrorMessage = "Missing address.")]
        [IntegerValidator]
        public int    AddressId   { get; set; }
        [Required(ErrorMessage = "Missing company size.")]
        [Range(1, 5)]
        public int    CompanySize { get; set; }
        [Required(ErrorMessage = "Missing IT size.")]
        [Range(1, 5)]
        public int    ItSize      { get; set; }
    }
}