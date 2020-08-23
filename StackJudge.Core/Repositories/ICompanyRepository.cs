using System.Collections.Generic;
using StackJudgeCore.Entity;

namespace StackJudgeCore.Repositories
{
    public interface ICompanyRepository
    {
        public List<Company> Search();
    }
}