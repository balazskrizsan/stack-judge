using System;
using System.ComponentModel.DataAnnotations;

namespace StackJudge.Requests
{
    public class AddressPostRequest
    {
        [Required(ErrorMessage = "Please provide `full address`.")]
        [MinLength(10, ErrorMessage = "Minimum length of `address` is 10.")]
        public string FullAddress { get; set; }

        [Required(ErrorMessage = "Please provide `latitude`.")]
        [RegularExpression(@"^\d{1,9}\.\d{1,20}$", ErrorMessage = "Incorrect `latitude` format.")]
        public Decimal MarkerLat { get; set; }

        [Required(ErrorMessage = "Please provide `longitude`.")]
        [RegularExpression(@"^\d{1,9}\.\d{1,20}$", ErrorMessage = "Incorrect `longitude` format.")]
        public Decimal MarkerLng { get; set; }

        [RegularExpression(@"^\d{1,9}\.\d{1,20}$", ErrorMessage = "Incorrect `manual latitude` format.")]
        public Decimal ManualMarkerLat { get; set; }

        [RegularExpression(@"^\d{1,9}\.\d{1,20}$", ErrorMessage = "Incorrect `manual longitude` format.")]
        public Decimal ManualMarkerLng { get; set; }
    }
}
