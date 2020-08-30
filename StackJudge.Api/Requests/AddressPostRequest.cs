using System;
using System.ComponentModel.DataAnnotations;

namespace StackJudge.Requests
{
    public class AddressPostRequest
    {
        [Required(ErrorMessage = "Please provide `address`.")]
        [MinLength(2, ErrorMessage = "Minimum length of `address` is 2.")]
        public string RawAddress { get; set; }

        [Required(ErrorMessage = "Missing `computed address`.")]
        [MinLength(10, ErrorMessage = "Minimum length of `computed address` is 2.")]
        public string GoogleAddress { get; set; }

        [Required(ErrorMessage = "Please provide `longitude`.")]
        [RegularExpression(@"^\d{1,9}\.\d{1,9}$", ErrorMessage = "Incorrect `longitude` format.")]
        public Decimal PingLong { get; set; }

        [Required(ErrorMessage = "Please provide `latitude`.")]
        [RegularExpression(@"^\d{1,9}\.\d{1,9}$", ErrorMessage = "Incorrect `latitude` format.")]
        public Decimal PingLat { get; set; }

        [RegularExpression(@"^\d{1,9}\.\d{1,9}$", ErrorMessage = "Incorrect `manual longitude` format.")]
        public Decimal ManualPingLong { get; set; }

        [RegularExpression(@"^\d{1,9}\.\d{1,9}$", ErrorMessage = "Incorrect `manual latitude` format.")]
        public Decimal ManualPingLat { get; set; }
    }
}
