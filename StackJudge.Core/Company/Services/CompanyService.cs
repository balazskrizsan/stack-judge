using System.Collections.Generic;
using StackJudgeCore.Company.Entities;
using StackJudgeCore.Company.Repositories;

namespace StackJudgeCore.Company.Services
{
    public class CompanyService : ICompanyService
    {
        private readonly ICompanyRepository        _companyRepository;
        private readonly IAddressService           _addressService;
        private readonly ITransactionRunnerService _transactionRunnerService;

        public CompanyService(
            ICompanyRepository companyRepository,
            IAddressService addressService,
            ITransactionRunnerService transactionRunnerService
        )
        {
            _companyRepository = companyRepository;
            _addressService = addressService;
            _transactionRunnerService = transactionRunnerService;
        }

        public List<Entities.Company> Search()
        {
            return _companyRepository.Search();
        }

        public int Create(Entities.Company company)
        {
            return _companyRepository.Create(company);
        }

        public void Create(Entities.Company company, Address address)
        {
            _transactionRunnerService.Run(
                () => CreateTransactional(company, address)
            );
        }

        private bool CreateTransactional(Entities.Company company, Address address)
        {
            int companyId = Create(company);

            address.CompanyId = companyId;
            _addressService.Create(address);
            
            return true;
        }

        public void Delete(int companyId)
        {
            _companyRepository.Delete(companyId);
        }
    }
}