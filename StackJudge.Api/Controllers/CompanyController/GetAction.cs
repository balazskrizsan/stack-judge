using Microsoft.AspNetCore.Mvc;
using StackJudge.Builders;
using StackJudge.Requests.Company;
using StackJudge.Response.Company;
using StackJudge.ValueObjects;
using StackJudgeCore.Company.Services;

namespace StackJudge.Controllers.CompanyController
{
    [ApiController]
    [Route("/company/")]
    public class GetAction
    {
        private readonly ICompanyService _companyService;

        public GetAction(ICompanyService companyService)
        {
            _companyService = companyService;
        }

        [HttpGet]
        [Route("{companyId}")]
        public ResponseEntity<ResponseData<GetResponse>> Get(int companyId, [FromQuery] GetQParams getQParams)
        {
            var responseEntityBuilder = new ResponseEntityBuilder<GetResponse>
            {
                Data = new GetResponse
                {
                    Company = _companyService.Get(companyId),
                    RequestRelationIds = getQParams.RequestRelationIds
                }
            };

            return responseEntityBuilder.Build();
        }
    }
}