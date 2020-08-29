using System;
using System.Transactions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using StackJudgeCore.Company.Services;

namespace StackJudgeEf.Service
{
    public class TransactionRunnerService : ITransactionRunnerService
    {
        private readonly ILogger<TransactionRunnerService> _logger;
        private readonly AppDbContext                      _context;

        public TransactionRunnerService(ILogger<TransactionRunnerService> logger, AppDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public T Run<T>(Func<T> workflow)
        {
            T result = default;
            ExecutionStrategyExtensions.Execute(_context.Database.CreateExecutionStrategy(), () =>
            {
                try
                {
                    using var scope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled);
                    result = workflow();
                    scope.Complete();
                }
                catch (TransactionAbortedException e)
                {
                    _logger.LogError(e, "TransactionRunnerService: commit error");
                    throw;
                }
                catch (AggregateException ae)
                {
                    throw ae.Flatten();
                }
            });
            return result;
        }
    }
}