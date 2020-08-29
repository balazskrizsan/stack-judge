﻿using System.Collections.Generic;
using System.Net;
using Microsoft.AspNetCore.Mvc;
using StackJudge.Builders;
using StackJudge.Requests;
using StackJudge.Services;
using StackJudge.ValueObjects;
using StackJudgeCore.Company.Entities;
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
        public ResponseEntity<ResponseData<List<Company>>> Get()
        {
            var responseEntityBuilder = new ResponseEntityBuilder<List<Company>>
            {
                Data = _companyService.Search()
            };

            return responseEntityBuilder.Build();
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

        [HttpDelete, Route("{companyId}")]
        public ResponseEntity<ResponseData<object>> Delete(int companyId)
        {
            _companyService.Delete(companyId);

            var responseEntityBuilder = new ResponseEntityBuilder<object>();

            return responseEntityBuilder.Build();
        }
    }
}