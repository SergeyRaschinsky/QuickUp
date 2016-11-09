using System.IO;
using WebApplication2.Exceptions;
using WebApplication2.Filters;

namespace WebApplication2.Controllers
{
    using Models.Input;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.Mvc;
    using WebApplication1.Services.Contracts;
    using System;

    [Route("api/[controller]")]
    public class IndexController : ControllerBase
    {
        private readonly IValuesService _valuesService;
        private readonly IHostingEnvironment _hostringEnvironment;

        public IndexController(IHostingEnvironment env, IValuesService valuesService)
        {
            _valuesService = valuesService;
            _hostringEnvironment = env;
        }

        [HttpGet]
        public IActionResult Index()
        {
            throw new ValidationException("Custom Error", "Error message");
            return Ok(_hostringEnvironment.ContentRootPath);
        }

        [HttpPost]
        public IActionResult Create(TestModel model)
        {
            return Ok(model);
        }
    }
}
