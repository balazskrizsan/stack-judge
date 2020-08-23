using System.Collections.Generic;

namespace StackJudgeCore.Company.Repositories
{
    public interface ICompanyRepository
    {
        public List<Entities.Company> Search();
        void Create(Entities.Company company);
    }
}