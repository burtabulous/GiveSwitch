﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace GiveSwitch.Areas.Users.Controllers
{
    [Area("Users")]
    [Route("users")]
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}