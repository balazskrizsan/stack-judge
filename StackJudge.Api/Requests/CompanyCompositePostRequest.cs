using StackJudgeCore.Company.Requests;

namespace StackJudge.Requests
{
    public class CompanyCompositePostRequest
    {
        public CompanyPostRequest Company { get; set; }
        public AddressPostRequest Address { get; set; }
    }
}