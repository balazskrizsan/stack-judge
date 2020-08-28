using Microsoft.AspNetCore.Mvc;

namespace StackJudge.ValueObjects
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