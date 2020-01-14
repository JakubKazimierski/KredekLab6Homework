using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Lab6JakubKazimierskiZadDom.Models;

namespace Lab6JakubKazimierskiZadDom.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        List<SuitsViewModel> suits;
        List<WhiskeyViewModel> drinks;
        List<CigarsViewModel> cigars;

        /// <summary>
        /// in constructor i create ready object of suits for sale in internet shop
        /// </summary>
        /// <param name="logger"></param>
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;

            suits = new List<SuitsViewModel>();
            drinks = new List<WhiskeyViewModel>();
            cigars = new List<CigarsViewModel>();

            suits.Add(new SuitsViewModel("Va'Banque", "Armani", 7110, "~/Content/ImagesSuits/armani1.png"));
            drinks.Add(new WhiskeyViewModel("Singleton", "Dream", 200, "~/Content/ImagesWhiskey/singleton.png"));
            cigars.Add(new CigarsViewModel("Havana", "CubanPete", 100, "~/Content/ImagesCigar/havana.png"));
        }
        /// <summary>
        /// link for buing  suits
        /// </summary>
        /// <returns></returns>
        public IActionResult GetAllSuits()
        {
            return View(suits);
        }

        public IActionResult GetAllWhiskey()
        {
            return View(drinks);
        }
        public IActionResult GetAllCigars()
        {
            return View(cigars);
        }

        public IActionResult Index()
        {
            return View();
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
