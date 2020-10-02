using System;
using StackJudge.Requests;
using StackJudge.Requests.Stack;
using StackJudgeCore.Company.Entities;

namespace StackJudge.Services
{
    public static class RequestMapperService
    {
        public static Company MapToEntity(CompanyPostRequest company, DateTime now, int userId)
        {
            return new Company(null, company.Name, company.CompanySizeId, company.ItSizeId, now, userId);
        }

        public static Address MapToEntity(AddressPostRequest address, DateTime now, int userId)
        {
            return new Address(
                null,
                null,
                address.FullAddress,
                address.MarkerLat,
                address.MarkerLng,
                address.ManualMarkerLat,
                address.ManualMarkerLng,
                now,
                userId
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
