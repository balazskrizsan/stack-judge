using Microsoft.AspNetCore.Mvc;

namespace StackJudge.Entities
{
    public class ResponseEntity<T> : ObjectResult
    {
        public int CustomStatusCode { get; set; }

        public ResponseEntity(T value) : base(value)
        {
            StatusCode = CustomStatusCode;
        }
    }
}