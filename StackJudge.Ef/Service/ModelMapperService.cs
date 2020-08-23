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
                Id = companyModel.Id, Name = companyModel.Name, Country = companyModel.Country, City = companyModel.City
            };
        }

        public static CompanyModel MapCompanyToModel(Company company)
        {
            return new CompanyModel
            {
                Id = company.Id, Name = company.Name, Country = company.Country, City = company.City
            };
        }
    }
}