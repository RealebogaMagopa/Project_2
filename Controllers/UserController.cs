﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication5.Controllers
{
    public class UserController : Controller
    {

        [Authorize(Roles = "User")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
