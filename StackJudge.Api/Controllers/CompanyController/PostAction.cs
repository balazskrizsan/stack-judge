using System;
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
            var now = DateTime.Now;
            _companyService.Create(
                RequestMapperService.MapToEntity(compositeRequest.Company, now, 1),
                RequestMapperService.MapToEntity(compositeRequest.Address, now, 1)
            );

            var responseEntityBuilder = new ResponseEntityBuilder<object>()
            {
                ResponseStatusCode = HttpStatusCode.Created
            };

            return responseEntityBuilder.Build();
        }
    }
}