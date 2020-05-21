using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using EthiopiaLanguageLearningPlatform.Models;

namespace EthiopiaLanguageLearningPlatform.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private CharactersDbContext _dbContext;

        public HomeController(ILogger<HomeController> logger, CharactersDbContext dbContext)
        {
            _logger = logger;

            _dbContext = dbContext;

            var test = "stop here";
        }

        public IActionResult Index()
        {
            var vm = new HomeViewModel();

            if(_dbContext.Character != null && _dbContext.Character.ToList().Count() > 0)
            {
                var chars = _dbContext.Character;

                vm.Characters = _dbContext.Character.ToList<Character>();
            }            

            return View(vm);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
