using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
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

        public List<RecursiveStack> RecursiveSearch(int companyId)
        {
            return _context.RecursiveStackModel.FromSqlRaw(
                    @"
WITH RECURSIVE rec(id, name, parent_id, depth, path) AS (
    SELECT S.id, S.name, S.parent_id, 1::INT AS depth, S.id::TEXT AS path FROM stack AS S WHERE S.company_id = {0} AND parent_id IS NULL
    UNION ALL
    SELECT SR.id, SR.name, SR.parent_id, R.depth + 1 AS depth, (R.path || '>' || SR.id::TEXT) FROM rec AS R, stack AS SR WHERE SR.parent_id = R.id
)
SELECT * FROM rec;",
                    companyId
                )
                .Select(model => ModelMapperService.MapFromModel(model))
                .ToList();
        }
    }
}
