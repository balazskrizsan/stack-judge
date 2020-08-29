using System.Net;
using Microsoft.AspNetCore.Mvc;
using StackJudge.Builders;
using StackJudge.Requests;
using StackJudge.Services;
using StackJudge.ValueObjects;
using StackJudgeCore.Company.Services;

namespace StackJudge.Controllers.CompanyController
{
    [ApiController]
    [Route("/company")]
    public class PostAction
    {
        private readonly ICompanyService _companyService;

        public PostAction(ICompanyService companyService)
        {
            _companyService = companyService;
        }

        [HttpPost]
        public ResponseEntity<ResponseData<object>> Post([FromForm] CompanyCompositePostRequest compositeRequest)
        {
            _companyService.Create(
                RequestMapperService.MapToEntity(compositeRequest.Company),
                RequestMapperService.MapToEntity(compositeRequest.Address)
            );

            var responseEntityBuilder = new ResponseEntityBuilder<object>()
            {
                ResponseStatusCode = HttpStatusCode.Created
            };

            return responseEntityBuilder.Build();
        }
    }
}