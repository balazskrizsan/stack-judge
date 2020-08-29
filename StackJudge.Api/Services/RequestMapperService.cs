using StackJudge.Requests;
using StackJudgeCore.Company.Entities;
using StackJudgeCore.Company.Requests;

namespace StackJudge.Services
{
    public static class RequestMapperService
    {
        public static Company MapToEntity(CompanyPostRequest company)
        {
            return new Company(null, company.Name, company.AddressId, company.CompanySize, company.ItSize);
        }

        public static Address MapToEntity(AddressPostRequest address)
        {
            return new Address(
                null,
                null,
                address.RawAddress,
                address.GoogleAddress,
                address.PingLat,
                address.PingLong,
                address.ManualPingLat,
                address.ManualPingLong
            );
        }
    }
}
