using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SmartScreen.Data;
using SmartScreen.Models;
using SmartScreen.Models.ViewModel;

namespace SmartScreen.Areas.CustomerCare.Controllers
{
    [Area("CustomerCare")]
    public class BnrCustomerController : Controller
    {
        private readonly ApplicationDbContext _db;
        [BindProperty]
        public CustomerViewModel CustomerVM { get; set; }

        public BnrCustomerController(ApplicationDbContext db)
        {
            _db = db;
            CustomerVM = new CustomerViewModel()
            {
                CustomerAccounts = _db.CustomerAccounts.ToList(),
                EconomicSubSectorCodeISICs = _db.EconomicSubSectorCodeISICs.ToList(),
                EconomicSubSectorCodes = _db.EconomicSubSectorCodes.ToList(),
                Educations = _db.Educations.ToList(),
                NaicsCodes = _db.NaicsCodes.ToList(),
                VillageLists = _db.VillageLists.ToList(),
                ResidenceTypes = _db.ResidenceTypes.ToList(),
                VisionSBUs = _db.VisionSBUs.ToList(),
                //VisionSBUId = _db.VisionSBUs.Select(e=>e.Id),
                BnrCustomer = new BnrCustomer()
            };

        }

     


        //[Route("/BnrCustomer/Create",
        //   Name = "Create")]
        //[HttpGet, ActionName("Create")]
        public IActionResult Create()
        {
            ViewData["CustomerVM"] = _db.VisionSBUs.ToList();
            return View(CustomerVM);
            //return RedirectToAction("/BnrCustomer/Create");
        }



        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        [Route("/BnrCustomer/Create")]
        public async Task<IActionResult> CreatePost()
        {
            //if (ModelState.IsValid)
            //{
                
            //}
            //return View(CustomerVM);

            _db.BnrCustomers.Add(CustomerVM.BnrCustomer);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Create));

            //Image


            //return RedirectToAction("Create", "BnrCustomer");

        }

        //[Route("/BnrCustomer/FindAccount/{accountNumber}")]
        //[HttpGet]
        //public JsonResult FindAccount(int accountNumber)
        //{
        //    List<CustomerAccount> customerAccount = _db.CustomerAccounts.Where(p => p.CustomerAccountNumber == accountNumber).ToList();

        //    //_db.BnrCustomers.Add(CustomerVM.BnrCustomer);
        //    //_db.SaveChanges();

        //    //Image


        //    return Json(customerAccount);

        //}
    }
}