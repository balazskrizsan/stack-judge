using Microsoft.AspNetCore.Mvc;
using StackJudge.Builders;
using StackJudge.ValueObjects;
using StackJudgeCore.Company.Services;

namespace StackJudge.Controllers.CompanyController
{
    [ApiController]
    [Route("/company")]
    public class DeleteAction
    {
        private readonly ICompanyService _companyService;

        public DeleteAction(ICompanyService companyService)
        {
            _companyService = companyService;
        }

        [HttpDelete, Route("{companyId}")]
        public ResponseEntity<ResponseData<object>> Delete(int companyId)
        {
            _companyService.Delete(companyId);

            var responseEntityBuilder = new ResponseEntityBuilder<object>();

            return responseEntityBuilder.Build();
        }
    }
}