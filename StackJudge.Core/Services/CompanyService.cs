using System.Collections.Generic;
using StackJudgeCore.Entity;
using StackJudgeCore.Repositories;

namespace StackJudgeCore.Services
{
    public class CompanyService : ICompanyService
    {
        private readonly ICompanyRepository _companyRepository;

        public CompanyService(ICompanyRepository companyRepository)
        {
            _companyRepository = companyRepository;
        }

        public List<Company> Search()
        {
            // return new List<Company> {new Company() {Id = 1, City = "City", Country = "country", Name = "name"}};
            return _companyRepository.Search();
        }
    }
}