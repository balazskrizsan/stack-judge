using StackJudgeCore.Company.Entities;
using StackJudgeCore.Company.Repositories;

namespace StackJudgeCore.Company.Services
{
    public class StackService : IStackService
    {
        private readonly IStackRepository _stackRepository;

        public StackService(IStackRepository stackRepository)
        {
            _stackRepository = stackRepository;
        }

        public void Create(Stack stack)
        {
            _stackRepository.Create(stack);
        }
    }
}
