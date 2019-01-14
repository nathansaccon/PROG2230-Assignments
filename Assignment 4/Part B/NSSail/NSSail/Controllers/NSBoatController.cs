using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NSSail.Models;
using Microsoft.AspNetCore.Http;

namespace NSSail.Controllers
{
    public class NSBoatController : Controller
    {
        private readonly SailContext _context;

        public NSBoatController(SailContext context)
        {
            _context = context;
        }

        // GET: NSBoat
        public async Task<IActionResult> Index(int? id)
        {
            if (id != null)
            {
                HttpContext.Session.SetString("id", id.ToString());
            }
            else
            {
                string sessionId = HttpContext.Session.GetString("id");
                if (sessionId == null)
                {
                    TempData["message"] = "Select a member to see their boats";
                    return RedirectToAction("Index", "NSMember");
                }
                else
                {
                    id = Convert.ToInt32(sessionId);
                }
            }
            
            TempData["name"] = _context.Member.Where(i => i.MemberId == id).ToList()[0].FullName;
            var sailContext = _context.Boat.Include(b => b.BoatType).Include(b => b.Member).Include(b => b.ParkingCodeNavigation);
            return View(sailContext.ToList().Where(i => i.MemberId == id).ToList().OrderBy(c => c.BoatClass));
        }

        // GET: NSBoat/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var boat = await _context.Boat
                .Include(b => b.BoatType)
                .Include(b => b.Member)
                .Include(b => b.ParkingCodeNavigation)
                .FirstOrDefaultAsync(m => m.BoatId == id);
            if (boat == null)
            {
                return NotFound();
            }
            ViewData["name"] = _context.Member.Where(x => x.MemberId == boat.MemberId).ToList()[0].FullName;
            return View(boat);
        }

        // GET: NSBoat/Create
        public IActionResult Create()
        {
            ViewData["name"] = _context.Member.Where(x => x.MemberId.ToString() == HttpContext.Session.GetString("id")).ToList()[0].FullName;
            ViewData["BoatTypeId"] = new SelectList(_context.BoatType.OrderBy(x => x.Name), "BoatTypeId", "Name");
            ViewData["MemberId"] = new SelectList(_context.Member.Where(i => i.MemberId.ToString() == HttpContext.Session.GetString("id")).ToList(), "MemberId", "FirstName");
            ViewData["ParkingCode"] = new SelectList(_context.Parking.Where(x => x.ActualBoatId == null).ToList(), "ParkingCode", "ParkingCode");
            return View();
        }

        // POST: NSBoat/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("BoatId,MemberId,BoatClass,HullColour,SailNumber,HullLength,BoatTypeId,ParkingCode")] Boat boat)
        {
            if (ModelState.IsValid)
            {
                _context.Add(boat);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["BoatTypeId"] = new SelectList(_context.BoatType, "BoatTypeId", "Name", boat.BoatTypeId);
            ViewData["MemberId"] = new SelectList(_context.Member, "MemberId", "FirstName", boat.MemberId);
            ViewData["ParkingCode"] = new SelectList(_context.Parking, "ParkingCode", "ParkingCode", boat.ParkingCode);
            return View(boat);
        }

        // GET: NSBoat/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var boat = await _context.Boat.FindAsync(id);
            if (boat == null)
            {
                return NotFound();
            }
            ViewData["name"] = _context.Member.Where(x => x.MemberId == boat.MemberId).ToList()[0].FullName;
            ViewData["BoatTypeId"] = new SelectList(_context.BoatType.OrderBy(x => x.Name), "BoatTypeId", "Name", boat.BoatTypeId);
            ViewData["MemberId"] = new SelectList(_context.Member.Where(i => i.MemberId.ToString() == HttpContext.Session.GetString("id")).ToList(), "MemberId", "FirstName", boat.MemberId);
            var parkingList = _context.Parking.Where(x => x.BoatTypeId == boat.BoatTypeId).Where(y => y.ActualBoatId == null).ToList();
            ViewData["ParkingCode"] = new SelectList(parkingList, "ParkingCode", "ParkingCode", boat.ParkingCode);
            return View(boat);
        }

        // POST: NSBoat/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("BoatId,MemberId,BoatClass,HullColour,SailNumber,HullLength,BoatTypeId,ParkingCode")] Boat boat)
        {
            if (id != boat.BoatId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(boat);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BoatExists(boat.BoatId))
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
            ViewData["BoatTypeId"] = new SelectList(_context.BoatType, "BoatTypeId", "Name", boat.BoatTypeId);
            ViewData["MemberId"] = new SelectList(_context.Member, "MemberId", "FirstName", boat.MemberId);
            ViewData["ParkingCode"] = new SelectList(_context.Parking, "ParkingCode", "ParkingCode", boat.ParkingCode);
            return View(boat);
        }

        // GET: NSBoat/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var boat = await _context.Boat
                .Include(b => b.BoatType)
                .Include(b => b.Member)
                .Include(b => b.ParkingCodeNavigation)
                .FirstOrDefaultAsync(m => m.BoatId == id);
            if (boat == null)
            {
                return NotFound();
            }
            ViewData["name"] = _context.Member.Where(x => x.MemberId == boat.MemberId).ToList()[0].FullName;
            return View(boat);
        }

        // POST: NSBoat/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var boat = await _context.Boat.FindAsync(id);
            _context.Boat.Remove(boat);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BoatExists(int id)
        {
            return _context.Boat.Any(e => e.BoatId == id);
        }
    }
}
