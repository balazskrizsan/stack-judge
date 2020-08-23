using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
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
        public List<Company> Get()
        {
            return _companyService.Search();
        }

        [HttpPost]
        public void Post([FromForm] CompanyPostRequest companyPostRequest)
        {
            _companyService.Create(RequestMapperService.MapCompanyPostRequestToEntity(companyPostRequest));
        }

        [HttpDelete, Route("{companyId}")]
        public object Delete(int companyId)
        {
            _companyService.Delete(companyId);

            return null;
        }
    }
}