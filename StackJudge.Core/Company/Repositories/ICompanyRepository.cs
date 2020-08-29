using System.Collections.Generic;

namespace StackJudgeCore.Company.Repositories
{
    public interface ICompanyRepository
    {
        public List<Entities.Company> Search();
        int Create(Entities.Company company);
        void Delete(int companyId);
    }
}