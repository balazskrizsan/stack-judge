using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using StackJudge.Builders;
using StackJudge.Response.Company;
using StackJudge.ValueObjects;
using StackJudgeCore.Company.Entities;
using StackJudgeCore.Company.Services;

namespace StackJudge.Controllers.CompanyController
{
    [ApiController]
    [Route("/company")]
    public class ListAction
    {
        private readonly ICompanyService _companyService;

        public ListAction(ICompanyService companyService)
        {
            _companyService = companyService;
        }

        [HttpGet]
        public ResponseEntity<ResponseData<ListResponse>> Get()
        {
            List<Company> companies = _companyService.Search();

            var responseEntityBuilder = new ResponseEntityBuilder<ListResponse>
            {
                Data = new ListResponse
                {
                    Companies = companies
                }
            };

            return responseEntityBuilder.Build();
        }
    }
}