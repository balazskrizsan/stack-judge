using System.Collections.Generic;
using StackJudgeCore.Entity;

namespace StackJudgeCore.Services
{
    public interface ICompanyService
    {
        public List<Company> Search();
    }
}