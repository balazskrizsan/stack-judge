using StackJudgeCore.Company.Entities;
using StackJudgeCore.Company.Repositories;
using StackJudgeEf.Service;

namespace StackJudgeEf.Repositories
{
    public class AddressRepository : IAddressRepository
    {
        private readonly AppDbContext _context;

        public AddressRepository(AppDbContext context)
        {
            _context = context;
        }

        public void Create(Address address)
        {
            _context.Address.Add(ModelMapperService.MapToModel(address));
            _context.SaveChanges();
        }
    }
}