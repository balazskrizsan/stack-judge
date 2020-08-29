using System;
using StackJudgeCore.Company.Entities;
using StackJudgeEf.Model;

namespace StackJudgeEf.Service
{
    public static class ModelMapperService
    {
        public static Company MapFromModel(CompanyModel companyModel)
        {
            return new Company
            {
                Id = companyModel.Id,
                Name = companyModel.Name,
                AddressId = companyModel.AddressId,
                CompanySize = companyModel.CompanySize,
                ItSize = companyModel.ItSize
            };
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
                CompanyId = address.CompanyId,
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