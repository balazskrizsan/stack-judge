using StackJudgeCore.Company.Requests;

namespace StackJudgeCore.Company.Services
{
    public static class RequestMapperService
    {
        public static Entities.Company MapCompanyPostRequestToEntity(CompanyPostRequest companyPostRequest)
        {
            return new Entities.Company
            {
                Name = companyPostRequest.Name,
                AddressId = companyPostRequest.AddressId,
                CompanySize = companyPostRequest.CompanySize,
                ItSize = companyPostRequest.ItSize
            };
        }
    }
}