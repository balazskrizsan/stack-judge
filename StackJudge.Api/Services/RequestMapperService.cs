using System;
using StackJudge.Requests;
using StackJudge.Requests.Stack;
using StackJudgeCore.Company.Entities;

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

        public static Stack MapToEntity(PostRequest request, DateTime now, int userId)
        {
            return new Stack(
                null,
                request.CompanyId,
                request.ParentId,
                request.TypeId,
                request.Name,
                request.MembersOnStackId,
                now,
                userId
            );
        }
    }
}
