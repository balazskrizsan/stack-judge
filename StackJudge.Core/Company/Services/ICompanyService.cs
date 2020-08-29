using System.Collections.Generic;
using StackJudgeCore.Company.Entities;

namespace StackJudgeCore.Company.Services
{
    public interface ICompanyService
    {
        public List<Entities.Company> Search();
        int Create(Entities.Company company);
        void Create(Entities.Company company, Address address);
        void Delete(int companyId);
    }
}
