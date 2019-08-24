using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraniteHouse2.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SmartScreen.Data;
using SmartScreen.Models;

namespace SmartScreen.Areas.CustomerCare.Controllers
{
    //[Authorize]
    [Area("CustomerCare")]
    public class BnrCustomersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BnrCustomersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: CustomerCare/BnrCustomers
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = await _context.BnrCustomers.Include(b => b.EconomicSubSectorCode).Include(b => b.EconomicSubSectorCodeISIC).Include(b => b.Education).Include(b => b.NaicsCode).Include(b => b.Residence).Include(b => b.Village).Include(b => b.Vision).LastAsync();
            List<BnrCustomer> BnrCustomer = new List<BnrCustomer>();
            BnrCustomer.Add(applicationDbContext);
            return View(BnrCustomer);
        }

        // GET: CustomerCare/BnrCustomers/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bnrCustomer = await _context.BnrCustomers
                
                .Include(b => b.EconomicSubSectorCode)
                .Include(b => b.EconomicSubSectorCodeISIC)
                .Include(b => b.Education)
                .Include(b => b.NaicsCode)
                .Include(b => b.Residence)
                .Include(b => b.Village)
                .Include(b => b.Vision)
                .FirstOrDefaultAsync(m => m.CustomerNumber == id);
            if (bnrCustomer == null)
            {
                return NotFound();
            }

            return View(bnrCustomer);
        }

        // GET: CustomerCare/BnrCustomers/Create
        public IActionResult Create()
        {
            //ViewData["CustomerAccountNumber"] = new SelectList(_context.CustomerAccounts, "CustomerAccountNumber", "FirstName");
            ViewData["EconomicSubSectorCodeId"] = new SelectList(_context.EconomicSubSectorCodes, "Code", "Description");
            ViewData["EconomicSubSectorCodeISICId"] = new SelectList(_context.EconomicSubSectorCodeISICs, "Code", "Description");
            ViewData["EducationCode"] = new SelectList(_context.Educations, "Code", "Description");
            ViewData["NaiscCode"] = new SelectList(_context.NaicsCodes, "Code", "Description");
            ViewData["ResidenceTypeCode"] = new SelectList(_context.ResidenceTypes, "Code", "Description");
            ViewData["VillageList"] = new SelectList(_context.VillageLists, "Villagelist", "VillagelistDescription");
            ViewData["VisionSBU"] = new SelectList(_context.VisionSBUs, "VisionSbu", "Description");
            return View();
        }

        // POST: CustomerCare/BnrCustomers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CustomerName,CustomerNumber,VisionSBU,VillageList,ResidenceTypeCode,EducationCode,NaiscCode,EconomicSubSectorCodeId,EconomicSubSectorCodeISICId")] BnrCustomer bnrCustomer)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bnrCustomer);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            //ViewData["CustomerAccountNumber"] = new SelectList(_context.CustomerAccounts, "CustomerAccountNumber", "FirstName", bnrCustomer.CustomerAccountNumber);
            ViewData["EconomicSubSectorCodeId"] = new SelectList(_context.EconomicSubSectorCodes, "Code", "Description", bnrCustomer.EconomicSubSectorCodeId);
            ViewData["EconomicSubSectorCodeISICId"] = new SelectList(_context.EconomicSubSectorCodeISICs, "Code", "Description", bnrCustomer.EconomicSubSectorCodeISICId);
            ViewData["EducationCode"] = new SelectList(_context.Educations, "Code", "Description", bnrCustomer.EducationCode);
            ViewData["NaiscCode"] = new SelectList(_context.NaicsCodes, "Code", "Description", bnrCustomer.NaiscCode);
            ViewData["ResidenceTypeCode"] = new SelectList(_context.ResidenceTypes, "Code", "Description", bnrCustomer.ResidenceTypeCode);
            ViewData["VillageList"] = new SelectList(_context.VillageLists, "Villagelist", "VillagelistDescription", bnrCustomer.VillageList);
            ViewData["VisionSBU"] = new SelectList(_context.VisionSBUs, "VisionSbu", "Description", bnrCustomer.VisionSBU);
            return View(bnrCustomer);
        }

        // GET: CustomerCare/BnrCustomers/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bnrCustomer = await _context.BnrCustomers.FindAsync(id);
            if (bnrCustomer == null)
            {
                return NotFound();
            }
            ViewData["EconomicSubSectorCodeId"] = new SelectList(_context.EconomicSubSectorCodes, "Code", "Description", bnrCustomer.EconomicSubSectorCodeId);
            ViewData["EconomicSubSectorCodeISICId"] = new SelectList(_context.EconomicSubSectorCodeISICs, "Code", "Description", bnrCustomer.EconomicSubSectorCodeISICId);
            ViewData["EducationCode"] = new SelectList(_context.Educations, "Code", "Description", bnrCustomer.EducationCode);
            ViewData["NaiscCode"] = new SelectList(_context.NaicsCodes, "Code", "Description", bnrCustomer.NaiscCode);
            ViewData["ResidenceTypeCode"] = new SelectList(_context.ResidenceTypes, "Code", "Description", bnrCustomer.ResidenceTypeCode);
            ViewData["VillageList"] = new SelectList(_context.VillageLists, "Villagelist", "VillagelistDescription", bnrCustomer.VillageList);
            ViewData["VisionSBU"] = new SelectList(_context.VisionSBUs, "VisionSbu", "Description", bnrCustomer.VisionSBU);
            return View(bnrCustomer);
        }

        // POST: CustomerCare/BnrCustomers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("CustomerName,CustomerNumber,VisionSBU,VillageList,ResidenceTypeCode,EducationCode,NaiscCode,EconomicSubSectorCodeId,EconomicSubSectorCodeISICId")] BnrCustomer bnrCustomer)
        {
            if (id != bnrCustomer.CustomerNumber)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bnrCustomer);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BnrCustomerExists(bnrCustomer.CustomerNumber))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            //ViewData["CustomerAccountNumber"] = new SelectList(_context.CustomerAccounts, "CustomerAccountNumber", "FirstName", bnrCustomer.CustomerAccountNumber);
            ViewData["EconomicSubSectorCodeId"] = new SelectList(_context.EconomicSubSectorCodes, "Code", "Description", bnrCustomer.EconomicSubSectorCodeId);
            ViewData["EconomicSubSectorCodeISICId"] = new SelectList(_context.EconomicSubSectorCodeISICs, "Code", "Description", bnrCustomer.EconomicSubSectorCodeISICId);
            ViewData["EducationCode"] = new SelectList(_context.Educations, "Code", "Description", bnrCustomer.EducationCode);
            ViewData["NaiscCode"] = new SelectList(_context.NaicsCodes, "Code", "Description", bnrCustomer.NaiscCode);
            ViewData["ResidenceTypeCode"] = new SelectList(_context.ResidenceTypes, "Code", "Description", bnrCustomer.ResidenceTypeCode);
            ViewData["VillageList"] = new SelectList(_context.VillageLists, "Villagelist", "VillagelistDescription", bnrCustomer.VillageList);
            ViewData["VisionSBU"] = new SelectList(_context.VisionSBUs, "VisionSbu", "Description", bnrCustomer.VisionSBU);
            return View(bnrCustomer);
        }

        // GET: CustomerCare/BnrCustomers/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bnrCustomer = await _context.BnrCustomers
               
                .Include(b => b.EconomicSubSectorCode)
                .Include(b => b.EconomicSubSectorCodeISIC)
                .Include(b => b.Education)
                .Include(b => b.NaicsCode)
                .Include(b => b.Residence)
                .Include(b => b.Village)
                .Include(b => b.Vision)
                .FirstOrDefaultAsync(m => m.CustomerNumber == id);
            if (bnrCustomer == null)
            {
                return NotFound();
            }

            return View(bnrCustomer);
        }

        // POST: CustomerCare/BnrCustomers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var bnrCustomer = await _context.BnrCustomers.FindAsync(id);
            _context.BnrCustomers.Remove(bnrCustomer);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BnrCustomerExists(string id)
        {
            return _context.BnrCustomers.Any(e => e.CustomerNumber == id);
        }

        [Route("/BnrCustomers/FindAccount/{accountNumber}")]
        [HttpGet]
        public JsonResult FindAccount(int accountNumber)
        {
            List<CustomerAccount> customerAccount = _context.CustomerAccounts.Where(p => p.CustomerAccountNumber == accountNumber).ToList();

            //_db.BnrCustomers.Add(CustomerVM.BnrCustomer);
            //_db.SaveChanges();

            //Image


            return Json(customerAccount);

        }
    }
}
