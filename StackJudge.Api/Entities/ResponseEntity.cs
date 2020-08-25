using Microsoft.AspNetCore.Mvc;

namespace StackJudge.Entities
{
    public class ResponseEntity : ObjectResult
    {
        public int CustomStatusCode { get; set; }

        public ResponseEntity(object value) : base(value)
        {
            StatusCode = CustomStatusCode;
        }
    }
}