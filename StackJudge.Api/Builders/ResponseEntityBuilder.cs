using System.Net;
using StackJudge.Entities;

namespace StackJudge.Builders
{
    public class ResponseEntityBuilder<T>
    {
        public T Data { get; set; }
        public int ErrorCode { get; set; }
        public HttpStatusCode StatusCode { get; set; } = HttpStatusCode.OK;

        public ResponseEntity Build()
        {
            bool success = ErrorCode == 0;

            var data = new ResponseData<T>
            {
                Data = Data, Success = success, ErrorCode = ErrorCode, RequestId = "1"
            };

            return new ResponseEntity(data)
            {
                StatusCode = StatusCode.GetHashCode()
            };
        }
    }
}