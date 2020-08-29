using StackJudgeCore.Company.Entities;
using StackJudgeCore.Company.Repositories;

namespace StackJudgeCore.Company.Services
{
    public class AddressService : IAddressService
    {
        private readonly IAddressRepository _addressRepository;

        public AddressService(IAddressRepository addressRepository)
        {
            _addressRepository = addressRepository;
        }

        public void Create(Address address)
        {
            _addressRepository.Create(address);
        }
    }
}
