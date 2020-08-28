using StackJudgeCore.Company.Entities;
using StackJudgeCore.Company.Requests;

namespace StackJudge.Services
{
    public static class RequestMapperService
    {
        public static Company MapCompanyPostRequestToEntity(CompanyPostRequest companyPostRequest)
        {
            return new Company
            {
                Name = companyPostRequest.Name,
                AddressId = companyPostRequest.AddressId,
                CompanySize = companyPostRequest.CompanySize,
                ItSize = companyPostRequest.ItSize
            };
        }
    }
}