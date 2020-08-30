using System.ComponentModel.DataAnnotations;
using System.Configuration;

namespace StackJudge.Requests.Stack
{
    public class PostRequest
    {
        [Required(ErrorMessage = "Please provide `company`.")]
        [IntegerValidator]
        public int CompanyId { get; set; }

        [IntegerValidator]
        public int? ParentId { get; set; } = null;

        [Required(ErrorMessage = "Please provide `type`.")]
        [IntegerValidator]
        [Range(1, 2, ErrorMessage = "Bad `Type` selected.")]
        public int TypeId { get; set; }

        [Required(ErrorMessage = "Please provide `name`.")]
        [MinLength(2, ErrorMessage = "Minimum length of `name` is 2.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please provide `members on stack`.")]
        [IntegerValidator]
        [Range(1, 7, ErrorMessage = "Bad `members on stack` selected.")]
        public int MembersOnStackId { get; set; }
    }
}
