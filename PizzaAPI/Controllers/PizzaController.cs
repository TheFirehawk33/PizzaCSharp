using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PizzaAPI.Repositories;
using PizzaAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PizzaController : ControllerBase
    {
        private readonly ILogger<PizzaController> _logger;

        public PizzaController(ILogger<PizzaController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Pizza> Get()
        {
            return PizzaService.Get();
        }

        [HttpGet("{name}")]
        public IEnumerable<Pizza> Get(string name)
        {
            return PizzaService.GetOne(name);
        }
    }
}