using System.Collections.Generic;

namespace StackJudgeCore.Company.Repositories
{
    public interface ICompanyRepository
    {
        public List<Entities.Company> Search();
        public Entities.Company Get(int id);
        public int Create(Entities.Company company);
        public void Delete(int companyId);
    }
}