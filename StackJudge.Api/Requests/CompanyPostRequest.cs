namespace StackJudgeCore.Company.Requests
{
    public class CompanyPostRequest
    {
        public string Name        { get; set; }
        public int    AddressId   { get; set; }
        public int    CompanySize { get; set; }
        public int    ItSize      { get; set; }
    }
}