using System.Collections.Generic;
using System.Linq;
using StackJudgeCore.Entity;
using StackJudgeCore.Repositories;
using StackJudgeEf.Service;

namespace StackJudgeEf.Repositories
{
    public class CompanyRepository : ICompanyRepository
    {
        private readonly AppDbContext _context;

        public CompanyRepository(AppDbContext context)
        {
            _context = context;
        }

        public List<Company> Search()
        {
            return _context.Companies.ToList().Select(company => ModelMapperService.MapCompany(company)).ToList();
        }
    }
}