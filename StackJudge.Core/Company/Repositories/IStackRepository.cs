using System.Collections.Generic;
using StackJudgeCore.Company.Entities;

namespace StackJudgeCore.Company.Repositories
{
    public interface IStackRepository
    {
        public void Create(Stack stack);
        public List<RecursiveStack> RecursiveSearch(int companyId);
    }
}
