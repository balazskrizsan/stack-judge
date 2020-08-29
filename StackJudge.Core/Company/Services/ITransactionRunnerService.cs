using System;

namespace StackJudgeCore.Company.Services
{
    public interface ITransactionRunnerService
    {
        public T Run<T>(Func<T> workflow);
    }
}