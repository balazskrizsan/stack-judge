using System;
using System.Net;
using Microsoft.AspNetCore.Mvc;
using StackJudge.Builders;
using StackJudge.Requests.Stack;
using StackJudge.Services;
using StackJudge.ValueObjects;
using StackJudgeCore.Company.Services;

namespace StackJudge.Controllers.StackController
{
    [ApiController]
    [Route("/stack")]
    public class PostAction
    {
        private readonly IStackService _stackService;

        public PostAction(IStackService stackService)
        {
            _stackService = stackService;
        }

        [HttpPost]
        public ResponseEntity<ResponseData<object>> Post([FromForm] PostRequest request)
        {
            _stackService.Create(RequestMapperService.MapToEntity(request, DateTime.Now, 1));

            var responseEntityBuilder = new ResponseEntityBuilder<object>
            {
                ResponseStatusCode = HttpStatusCode.Created
            };

            return responseEntityBuilder.Build();
        }
    }
}
