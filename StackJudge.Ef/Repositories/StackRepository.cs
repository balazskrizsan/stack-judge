using StackJudgeCore.Company.Entities;
using StackJudgeCore.Company.Repositories;
using StackJudgeEf.Service;

namespace StackJudgeEf.Repositories
{
    public class StackRepository : IStackRepository
    {
        private readonly AppDbContext _context;

        public StackRepository(AppDbContext context)
        {
            _context = context;
        }

        public void Create(Stack stack)
        {
            _context.Stack.Add(ModelMapperService.MapToModel(stack));
            _context.SaveChanges();
        }
    }
}