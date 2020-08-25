using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using StackJudge.Builders;
using StackJudge.Entities;
using StackJudgeCore.Company.Entities;
using StackJudgeCore.Company.Requests;
using StackJudgeCore.Company.Services;

namespace StackJudge.Controllers
{
    [ApiController]
    [Route("/company")]
    public class CompanyController : ControllerBase
    {
        private readonly ICompanyService _companyService;

        public CompanyController(ICompanyService companyService)
        {
            _companyService = companyService;
        }

        [HttpGet]
        public ResponseEntity Get()
        {
            var responseEntityBuilder = new ResponseEntityBuilder<List<Company>>
            {
                Data = _companyService.Search()
            };

            return responseEntityBuilder.Build();
        }

        [HttpPost]
        public ResponseEntity Post([FromForm] CompanyPostRequest companyPostRequest)
        {
            _companyService.Create(RequestMapperService.MapCompanyPostRequestToEntity(companyPostRequest));

            var responseEntityBuilder = new ResponseEntityBuilder<List<Company>>();

            return responseEntityBuilder.Build();
        }

        [HttpDelete, Route("{companyId}")]
        public ResponseEntity Delete(int companyId)
        {
            _companyService.Delete(companyId);

            var responseEntityBuilder = new ResponseEntityBuilder<List<Company>>();

            return responseEntityBuilder.Build();
        }
    }
}