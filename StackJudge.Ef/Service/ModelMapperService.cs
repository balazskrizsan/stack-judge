using StackJudgeCore.Entity;
using StackJudgeEf.Model;

namespace StackJudgeEf.Service
{
    public static class ModelMapperService
    {
        public static Company MapCompany(CompanyModel companyModel)
        {
            return new Company
            {
                Id = companyModel.Id, Name = companyModel.Name, Country = companyModel.Country, City = companyModel.City
            };
        }
    }
}