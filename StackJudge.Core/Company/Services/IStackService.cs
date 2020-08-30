using System.Collections.Generic;
using StackJudgeCore.Company.Entities;

namespace StackJudgeCore.Company.Services
{
    public interface IStackService
    {
        public void Create(Stack stack);
        List<RecursiveStack> RecursiveSearch(int companyId);
    }
}
