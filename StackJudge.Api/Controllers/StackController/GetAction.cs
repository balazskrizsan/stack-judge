using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using StackJudge.Builders;
using StackJudge.ValueObjects;
using StackJudgeCore.Company.Entities;
using StackJudgeCore.Company.Services;

namespace StackJudge.Controllers.StackController
{
    [ApiController]
    [Route("/stack-recursive")]
    public class GetAction
    {
        private readonly IStackService _stackService;

        public GetAction(IStackService stackService)
        {
            _stackService = stackService;
        }

        [HttpGet]
        [Route("{companyId}")]
        public ResponseEntity<ResponseData<List<RecursiveStack>>> Get(int companyId)
        {
            var responseEntityBuilder = new ResponseEntityBuilder<List<RecursiveStack>>
            {
                Data = _stackService.RecursiveSearch(companyId)
            };

            return responseEntityBuilder.Build();
        }
    }
}
