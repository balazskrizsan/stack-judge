using Microsoft.AspNetCore.Mvc;
using StackJudge.Builders;
using StackJudge.Response.Stack;
using StackJudge.ValueObjects;
using StackJudgeCore.Company.Services;

namespace StackJudge.Controllers.StackController
{
    [ApiController]
    [Route("/stack/recursive")]
    public class RecursiveGetAction
    {
        private readonly IStackService _stackService;

        public RecursiveGetAction(IStackService stackService)
        {
            _stackService = stackService;
        }

        [HttpGet]
        [Route("{companyId}")]
        public ResponseEntity<ResponseData<RecursiveGetResponse>> Get(int companyId)
        {
            var responseEntityBuilder = new ResponseEntityBuilder<RecursiveGetResponse>
            {
                Data = new RecursiveGetResponse
                {
                    RecursiveStacks = _stackService.RecursiveSearch(companyId)
                }
            };

            return responseEntityBuilder.Build();
        }
    }
}