﻿using Claim.Interfaces;
using Claim.Models;
using Claim.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace Claim.Controllers
{
    [Route("api")]
    [ApiController]
    public class ClaimsController : ControllerBase
    {
        readonly IClaimServices _services;

        public ClaimsController(IClaimServices services)
        {
            _services = services;
        }

        //GET METHODS

        [HttpGet]
        [Route("Claims/GetClaims")]
        public ActionResult GetClaims(int claimId = 0)
        {
            var result = _services.GetClaims(claimId);
            return Ok(result);
        }
        [HttpGet]
        [Route("Policy/GetPolicy")]
        public ActionResult GetPolicy(int policyId = 0)
        {
            var result = _services.GetPolicy(policyId);
            return Ok(result);
        }
        [HttpGet]
        [Route("Customer/GetCustomer")]
        public ActionResult GetCustomer(int customerId = 0)
        {
            var result = _services.GetCustomer(customerId);
            return Ok(result);
        }
        [HttpGet]
        [Route("Claimant/GetClaimant")]
        public ActionResult GetClaimant(int claimantId = 0)
        {
            var result = _services.GetCustomer(claimantId);
            return Ok(result);
        }
        [HttpGet]
        //[Route("get/matched")]
        //public ActionResult GetGeneric(string data)
        //{
        //    var result = _services.GetMatchedData(data);
        //    return Ok(result);
        //}
        //POST METHODS

        [HttpPost]
        [Route("Claims/CreateClaim")]
        public ActionResult CreateClaim(Claims claims)
        {
            var result = _services.CreateClaim(claims);
            return Ok(result);
        }
        [HttpPost]
        [Route("Policy/CreatePolicy")]
        public ActionResult CreatePolicy(Policy policy)
        {
            var result = _services.CreatePolicy(policy);
            return Ok(result);
        }
        [HttpPost]
        [Route("Customer/CreateCustomer")]
        public ActionResult CreateCustomer(Customer customer)
        {
            var result = _services.CreateCustomer(customer);
            return Ok(result);
        }
        [HttpPost]
        [Route("Claimant/CreateClaimant")]
        public ActionResult CreateClaimant(Claimant claimant)
        {
            var result = _services.CreateClaimant(claimant);
            return Ok(result);
        }
        [HttpPost]
        public async Task<IActionResult> ReceiveJson(List<GenericVM> genericVMList)
        {
            try
            {

                List<GenericVM> responseList = _services.ReceivedValue(genericVMList);
                return Ok(responseList);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}
