using System.Collections.Generic;
using StackJudgeCore.Company.Entities;

namespace StackJudgeCore.Company.Services
{
    public interface ICompanyService
    {
        public List<Entities.Company> Search();
        public Entities.Company Get(int id);
        int Create(Entities.Company company);
        void Create(Entities.Company company, Address address);
        void Delete(int companyId, int userId);
    }
}
