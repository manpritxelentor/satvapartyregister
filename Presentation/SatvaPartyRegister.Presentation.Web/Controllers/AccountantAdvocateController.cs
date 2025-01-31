﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kendo.Mvc.UI;
using Microsoft.AspNetCore.Mvc;
using SatvaPartyRegister.Presentation.Web.Models.AccountantAdvocate;
using SatvaPartyRegister.Presentation.Web.Services;

namespace SatvaPartyRegister.Presentation.Web.Controllers
{
    public class AccountantAdvocateController : Controller
    {
        private readonly AccountAdvocateService _accountAdvocateService;

        public AccountantAdvocateController(AccountAdvocateService accountAdvocateService)
        {
            _accountAdvocateService = accountAdvocateService;
        }

        public IActionResult List()
        {
            return View();
        }

        public async Task<IActionResult> GetAll([DataSourceRequest]DataSourceRequest dataSourceRequest)
        {
            var data = await _accountAdvocateService.GetAll(dataSourceRequest);
            return Json(data.ResponseObject);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(AddUpdateAccountantAdvocateViewModel objModel)
        {
            var data = await _accountAdvocateService.CreateAccountantAdvocate(objModel);
            return RedirectToAction("List");
        }

        public IActionResult Edit(int id)
        {
            return View();
        }

    }
}