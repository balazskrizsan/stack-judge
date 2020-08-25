namespace StackJudge.Entities
{
    public class ResponseData<T>
    {
        public T Data { get; set; }
        public bool Success { get; set; }
        public int ErrorCode { get; set; }
        public string RequestId { get; set; }
    }
}