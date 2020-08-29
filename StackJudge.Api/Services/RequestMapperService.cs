using StackJudge.Requests;
using StackJudgeCore.Company.Entities;
using StackJudgeCore.Company.Requests;

namespace StackJudge.Services
{
    public static class RequestMapperService
    {
        public static Company MapToEntity(CompanyPostRequest companyPostRequest)
        {
            return new Company
            {
                Name = companyPostRequest.Name,
                AddressId = companyPostRequest.AddressId,
                CompanySize = companyPostRequest.CompanySize,
                ItSize = companyPostRequest.ItSize
            };
        }

        public static Address MapToEntity(AddressPostRequest addressPostRequest)
        {
            return new Address
            {
                RawAddress = addressPostRequest.RawAddress,
                GoogleAddress = addressPostRequest.GoogleAddress,
                PinLat = addressPostRequest.PingLat,
                PinLong = addressPostRequest.PingLong,
                ManualPinLat = addressPostRequest.ManualPingLat,
                ManualPinLong = addressPostRequest.ManualPingLong,
            };
        }
    }
}