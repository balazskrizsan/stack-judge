using System;
using StackJudgeCore.Company.Entities;
using StackJudgeEf.Model;

namespace StackJudgeEf.Service
{
    public static class ModelMapperService
    {
        public static Company MapCompanyFromModel(CompanyModel companyModel)
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

        public static CompanyModel MapCompanyToModel(Company company)
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
    }
}