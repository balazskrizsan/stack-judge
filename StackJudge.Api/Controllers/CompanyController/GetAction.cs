﻿using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using StackJudge.Builders;
using StackJudge.ValueObjects;
using StackJudgeCore.Company.Entities;
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
        public ResponseEntity<ResponseData<Company>> Get(int companyId)
        {
            var responseEntityBuilder = new ResponseEntityBuilder<Company>
            {
                Data = _companyService.Get(companyId)
            };

            return responseEntityBuilder.Build();
        }
    }
}