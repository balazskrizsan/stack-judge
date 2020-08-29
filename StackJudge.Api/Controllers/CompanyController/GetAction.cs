using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using StackJudge.Builders;
using StackJudge.ValueObjects;
using StackJudgeCore.Company.Entities;
using StackJudgeCore.Company.Services;

namespace StackJudge.Controllers.CompanyController
{
    [ApiController]
    [Route("/company")]
    public class GetAction
    {
        private readonly ICompanyService _companyService;

        public GetAction(ICompanyService companyService)
        {
            _companyService = companyService;
        }

        [HttpGet]
        public ResponseEntity<ResponseData<List<Company>>> Get()
        {
            var responseEntityBuilder = new ResponseEntityBuilder<List<Company>>
            {
                Data = _companyService.Search()
            };

            return responseEntityBuilder.Build();
        }
    }
}