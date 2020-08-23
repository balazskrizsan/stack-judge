using System.Collections.Generic;
using StackJudgeCore.Company.Repositories;
using StackJudgeCore.Company.Requests;

namespace StackJudgeCore.Company.Services
{
    public class CompanyService : ICompanyService
    {
        private readonly ICompanyRepository _companyRepository;

        public CompanyService(ICompanyRepository companyRepository)
        {
            _companyRepository = companyRepository;
        }

        public List<Entities.Company> Search()
        {
            return _companyRepository.Search();
        }

        public void Create(Entities.Company company)
        {
            _companyRepository.Create(company);
        }

        public void Delete(int companyId)
        {
            _companyRepository.Delete(companyId);
        }
    }
}