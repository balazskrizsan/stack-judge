using System.Collections.Generic;

namespace StackJudgeCore.Company.Services
{
    public interface ICompanyService
    {
        public List<Entities.Company> Search();
        void Create(Entities.Company company);
        void Delete(int companyId);
    }
}