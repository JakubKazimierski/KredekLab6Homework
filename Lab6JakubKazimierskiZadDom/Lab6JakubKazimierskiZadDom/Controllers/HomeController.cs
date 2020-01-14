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

        /// <summary>
        /// lists of itesms on subsites
        /// </summary>
        List<SuitsViewModel> suits;
        List<WhiskeyViewModel> drinks;
        List<CigarsViewModel> cigars;

        /// <summary>
        /// in constructor i create ready object of items for sale in internet shop
        /// </summary>
        /// <param name="logger"></param>
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;

            //creating objects
            suits = new List<SuitsViewModel>();
            drinks = new List<WhiskeyViewModel>();
            cigars = new List<CigarsViewModel>();

            #region suits
            suits.Add(new SuitsViewModel("Va'Banque", "Armani", 7110, "~/Content/ImagesSuits/armani1.png"));
            suits.Add(new SuitsViewModel("Mistress", "Hugo-Boss", 9800, "~/Content/ImagesSuits/boss1.png"));
            suits.Add(new SuitsViewModel("Night", "Versace", 8300, "~/Content/ImagesSuits/versace1.png"));
            suits.Add(new SuitsViewModel("The World", "Armani", 4670, "~/Content/ImagesSuits/armani2.png"));
            suits.Add(new SuitsViewModel("Hermit-Purple", "Hugo-Boss", 2310, "~/Content/ImagesSuits/boss2.png"));
            suits.Add(new SuitsViewModel("Star-Platinum", "Versace", 9430, "~/Content/ImagesSuits/versace2.png"));
            suits.Add(new SuitsViewModel("Status-Quo", "Armani", 6650, "~/Content/ImagesSuits/armani3.png"));
            suits.Add(new SuitsViewModel("Sean-Connery", "Hugo-Boss", 4510, "~/Content/ImagesSuits/boss3.png"));
            suits.Add(new SuitsViewModel("Dio", "Versace", 3140, "~/Content/ImagesSuits/versace3.png"));
            #endregion

            #region drinks
            drinks.Add(new WhiskeyViewModel("Singleton", "Dream", 210, "~/Content/ImagesWhiskey/singleton.png"));
            drinks.Add(new WhiskeyViewModel("Star-Ward", "Stars", 140, "~/Content/ImagesWhiskey/starward.png"));
            drinks.Add(new WhiskeyViewModel("Suthern-Comfort", "California", 230, "~/Content/ImagesWhiskey/suthernComfort.png"));
            drinks.Add(new WhiskeyViewModel("Remy-Martin", "Requiem", 310, "~/Content/ImagesWhiskey/remyMartin.png"));
            drinks.Add(new WhiskeyViewModel("Powers", "Martinez", 215, "~/Content/ImagesWhiskey/powers.png"));
            drinks.Add(new WhiskeyViewModel("Knob-Creek", "King-Creek", 340, "~/Content/ImagesWhiskey/knobCreek2.png"));
            drinks.Add(new WhiskeyViewModel("Crown-Royal", "Royal-Ruby", 500, "~/Content/ImagesWhiskey/crownRoyal.png"));
            drinks.Add(new WhiskeyViewModel("Chivas-Regal", "Chivas", 260, "~/Content/ImagesWhiskey/chivasRegal2.png"));
            drinks.Add(new WhiskeyViewModel("Charleston", "Charles-Company", 150, "~/Content/ImagesWhiskey/charleston.png"));
            #endregion

            #region cigars
            cigars.Add(new CigarsViewModel("Havana", "CubanPete", 100, "~/Content/ImagesCigar/havana.png"));
            cigars.Add(new CigarsViewModel("Mexicano", "New-Mexico", 200, "~/Content/ImagesCigar/mexico.png"));
            cigars.Add(new CigarsViewModel("Blue-Mountain", "Paramount", 340, "~/Content/ImagesCigar/blueMountain.png"));
            cigars.Add(new CigarsViewModel("Cohiba", "Catharsis", 250, "~/Content/ImagesCigar/cohiba.png"));
            cigars.Add(new CigarsViewModel("Cuban-Can", "Cuba", 110, "~/Content/ImagesCigar/cubanaCan.png"));
            cigars.Add(new CigarsViewModel("Esteli", "Estrid", 300, "~/Content/ImagesCigar/esteli.png"));
            cigars.Add(new CigarsViewModel("Monte-Christo", "Lord", 150, "~/Content/ImagesCigar/montechristo.png"));
            cigars.Add(new CigarsViewModel("Ramon-Allones", "Ramones", 240, "~/Content/ImagesCigar/ramonAllones.png"));
            cigars.Add(new CigarsViewModel("Trinidad", "Manifesto", 130, "~/Content/ImagesCigar/trinidad.png"));
            #endregion

        }
        /// <summary>
        /// link for buing  suits
        /// </summary>
        /// <returns></returns>
        public IActionResult GetAllSuits()
        {
            return View(suits);
        }

        /// <summary>
        /// method/link for drinks site
        /// </summary>
        /// <returns></returns>
        public IActionResult GetAllWhiskey()
        {
            return View(drinks);
        }

        /// <summary>
        /// region/link for cigars site
        /// </summary>
        /// <returns></returns>
        public IActionResult GetAllCigars()
        {
            return View(cigars);
        }

        #region Forms
        
        /// <summary>
        /// get request for data from user
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult ContactForm()
        {
            return View();
        }

        /// <summary>
        /// post request for temporary data gained from user
        /// </summary>
        /// <param name="formViewModel"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult ContactForm(ContactFormViewModel formViewModel)
        {
            string firstName = formViewModel.FirstName;
            string lastName = formViewModel.LastName;
            string item = formViewModel.ProductName;
            ViewBag.UserName = firstName;//ulotne dane
            ViewBag.UserLastName = lastName;//ulotne dane
            ViewBag.ProductName = item;
            return View("ContactFormGreetings");
        }

        /// <summary>
        /// get request for data from user
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult ComplainForm()
        {
            return View();
        }

        /// <summary>
        /// post request for temporary data from user
        /// </summary>
        /// <param name="formViewModel"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult ComplainForm(ComplainViewModel formViewModel)
        {
            string firstName = formViewModel.FirstName;
            string lastName = formViewModel.LastName;
            string complaint = formViewModel.Complain;
            ViewBag.UserName = firstName;//ulotne dane
            ViewBag.UserLastName = lastName;//ulotne dane
            ViewBag.Complain = complaint;//ulotne dane
            return View("ComplainFormAfter");
        }

        /// <summary>
        /// get request for data from user
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult WorkForm()
        {
            return View();
        }

        /// <summary>
        /// post request for data from user
        /// </summary>
        /// <param name="formViewModel"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult WorkForm(WorkWithUsViewModel formViewModel)
        {
            string firstName = formViewModel.FirstName;
            string lastName = formViewModel.LastName;
            string university = formViewModel.University;
            string motivation = formViewModel.Motivation;
            ViewBag.UserName = firstName;//ulotne dane
            ViewBag.UserLastName = lastName;//ulotne dane
            ViewBag.University = university;
            ViewBag.Motivation = motivation;
            return View("WorkFormAfter");
        }

        #endregion

        /// <summary>
        /// link/method of main site
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// link/method of site with privacy infos
        /// </summary>
        /// <returns></returns>
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
