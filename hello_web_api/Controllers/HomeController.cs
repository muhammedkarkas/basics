﻿using hello_web_api.Models;
using Microsoft.AspNetCore.Mvc;

namespace hello_web_api.Controllers
{
    [ApiController]
    [Route("home")]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetMessage()
        {
            var result = new ResponseModel()
            {
                HttpStatus = 200,
                Message = "Hello ASP.NET Core WEB API"
            }; 

            return Ok(result);
        }
    }
}

    