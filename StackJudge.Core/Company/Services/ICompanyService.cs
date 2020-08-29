using System.Collections.Generic;

namespace StackJudgeCore.Company.Services
{
    public interface ICompanyService
    {
        public List<Entities.Company> Search();
        int Create(Entities.Company company);
        void Create(Entities.Company company, Entities.Address address);
        void Delete(int companyId);
    }
}