using System.Collections.Generic;
using System.Linq;
using StackJudgeCore.Company.Entities;
using StackJudgeCore.Company.Repositories;
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
            return _context
                .Companies
                .ToList()
                .Select(company => ModelMapperService.MapCompanyFromModel(company))
                .ToList();
        }

        public void Create(Company company)
        {
            _context.Companies.Add(ModelMapperService.MapCompanyToModel(company));
            _context.SaveChanges();
        }
    }
}