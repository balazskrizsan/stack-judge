using System;
using StackJudgeCore.Company.Entities;
using StackJudgeEf.Model;

namespace StackJudgeEf.Service
{
    public static class ModelMapperService
    {
        public static Company MapFromModel(CompanyModel company)
        {
            return new Company(company.Id, company.Name, company.AddressId, company.CompanySize, company.ItSize);
        }

        public static CompanyModel MapToModel(Company company)
        {
            return new CompanyModel
            {
                Id = company.Id,
                Name = company.Name,
                AddressId = company.AddressId,
                CompanySize = company.CompanySize,
                ItSize = company.ItSize,
                CreatedAt = DateTime.Now,
                CreatedBy = 1
            };
        }

        public static AddressModel MapToModel(Address address)
        {
            return new AddressModel
            {
                Id = address.Id,
                CompanyId = (int) address.CompanyId,
                RawAddress = address.RawAddress,
                GoogleAddress = address.GoogleAddress,
                PinLong = address.PinLong,
                PinLat = address.PinLat,
                ManualPinLong = address.ManualPinLong,
                ManualPinLat = address.ManualPinLat,
                CreatedAt = DateTime.Now,
                CreatedBy = 1
            };
        }
    }
}