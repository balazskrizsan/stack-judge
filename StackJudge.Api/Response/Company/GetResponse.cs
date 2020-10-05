using System.Collections.Generic;

namespace StackJudge.Response.Company
{
    public class GetResponse
    {
        public StackJudgeCore.Company.Entities.Company Company { get; set; }
        public List<int> RequestRelationIds  { get; set; }
    }
}