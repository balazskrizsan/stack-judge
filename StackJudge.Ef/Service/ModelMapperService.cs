using System;
using StackJudgeCore.Company.Entities;
using StackJudgeEf.Model;

namespace StackJudgeEf.Service
{
    public static class ModelMapperService
    {
        public static Company MapFromModel(CompanyModel company)
        {
            return new Company(
                company.Id,
                company.Name,
                company.CompanySize,
                company.ItSize,
                company.CreatedAt,
                company.CreatedBy
            );
        }

        public static CompanyModel MapToModel(Company company)
        {
            return new CompanyModel
            {
                Id = company.Id,
                Name = company.Name,
                CompanySize = company.CompanySize,
                ItSize = company.ItSize,
                CreatedAt = company.CreatedAt,
                CreatedBy = company.CreatedBy
            };
        }

        public static AddressModel MapToModel(Address address)
        {
            return new AddressModel
            {
                Id = address.Id,
                CompanyId = address.CompanyId ?? 0,
                FullAddress = address.FullAddress,
                MarkerLat = address.MarkerLat,
                MarkerLng = address.MarkerLng,
                ManualMarkerLat = address.ManualMarkerLat,
                ManualMarkerLng = address.ManualMarkerLng,
                CreatedAt = address.CreatedAt,
                CreatedBy = address.CreatedBy
            };
        }

        public static StackModel MapToModel(Stack stack)
        {
            return new StackModel
            {
                Id = stack.Id,
                CompanyId = stack.CompanyId,
                ParentId = stack.ParentId,
                Name = stack.Name,
                MembersOnStackId = stack.MembersOnStackId,
                CreatedAt = stack.CreatedAt,
                CreatedBy = stack.CreatedBy
            };
        }

        public static RecursiveStack MapFromModel(RecursiveStackModel recursiveStack)
        {
            return new RecursiveStack(
                recursiveStack.Id,
                recursiveStack.Name,
                recursiveStack.ParentId,
                recursiveStack.Depth,
                recursiveStack.Path
            );
        }
    }
}
