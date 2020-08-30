using System;
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
                .Select(company => ModelMapperService.MapFromModel(company))
                .ToList();
        }

        public int Create(Company company)
        {
            var newCompany = ModelMapperService.MapToModel(company);

            _context.Companies.Add(newCompany);
            _context.SaveChanges();

            if (newCompany.Id == null)
            {
                throw new Exception("User creation exception.");
            }

            return newCompany.Id ?? 0;
        }

        public void Delete(int companyId)
        {
            var company = _context.Companies.Single(c => c.Id == companyId);
            _context.Companies.Remove(company);
            _context.SaveChanges();
        }
    }
}
