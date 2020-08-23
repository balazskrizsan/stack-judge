using System.Collections.Generic;
using StackJudgeCore.Company.Requests;

namespace StackJudgeCore.Company.Services
{
    public interface ICompanyService
    {
        public List<Entities.Company> Search();
        void Create(Entities.Company company);
    }
}