using System;
using System.ComponentModel.DataAnnotations;

namespace StackJudge.Requests
{
    public class AddressPostRequest
    {
        [Required(ErrorMessage = "Please enter address.")]
        [MinLength(10, ErrorMessage = "Min length 10 chars.")]
        public string  RawAddress     { get; set; }
        [Required(ErrorMessage = "Missing computed address.")]
        [MinLength(10, ErrorMessage = "Min length 10 chars.")]
        public string  GoogleAddress  { get; set; }
        [Required(ErrorMessage = "Missing longitude.")]
        [RegularExpression(@"^\d{1,9}\.\d{1,9}$", ErrorMessage = "Incorrect longitude format.")]
        public Decimal PingLong       { get; set; }
        [Required(ErrorMessage = "Missing latitude.")]
        [RegularExpression(@"^\d{1,9}\.\d{1,9}$", ErrorMessage = "Incorrect latitude format.")]
        public Decimal PingLat        { get; set; }
        [RegularExpression(@"^\d{1,9}\.\d{1,9}$", ErrorMessage = "Incorrect manual longitude format.")]
        public Decimal ManualPingLong { get; set; }
        [RegularExpression(@"^\d{1,9}\.\d{1,9}$", ErrorMessage = "Incorrect manual latitude format.")]
        public Decimal ManualPingLat  { get; set; }
    }
}