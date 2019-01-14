using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using NSSail.Models;

namespace NSSail.Controllers
{
    public class NSMembershipController : Controller
    {
        private readonly SailContext _context;

        public NSMembershipController(SailContext context)
        {
            _context = context;
        }

        // GET: NSMembership
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
                    TempData["message"] = "Select a member to see their memberships";
                    return RedirectToAction("Index", "NSMember");
                }else
                {
                    id = Convert.ToInt32(sessionId);
                }
            }

            ViewData["name"] = _context.Member.Where(x => x.MemberId == id).ToList()[0].FullName;

            var sailContext = _context.Membership.Include(m => m.Member).Include(m => m.MembershipTypeNameNavigation);
            return View(sailContext.ToList().Where(x => x.MemberId == id).OrderBy(y => -y.Year));
        }

        // GET: NSMembership/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var membership = await _context.Membership
                .Include(m => m.Member)
                .Include(m => m.MembershipTypeNameNavigation)
                .FirstOrDefaultAsync(m => m.MembershipId == id);
            if (membership == null)
            {
                return NotFound();
            }
            ViewData["head"] = "Details About Membership For " + membership.Member.FullName;
            return View(membership);
        }

        // GET: NSMembership/Create
        public IActionResult Create()
        {
            ViewData["head"] = "Create Membership For " + _context.Member.Where(x => x.MemberId.ToString() == HttpContext.Session.GetString("id")).ToList()[0].FullName;
            ViewData["Year"] = DateTime.Today.Year;
            ViewData["MemberId"] = new SelectList(_context.Member.Where(x => x.MemberId.ToString() == HttpContext.Session.GetString("id")), "MemberId", "FirstName");
            ViewData["MembershipTypeName"] = new SelectList(_context.MembershipType.OrderBy(x => x.MembershipTypeName), "MembershipTypeName", "MembershipTypeName");
            return View();
        }

        // POST: NSMembership/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MembershipId,MemberId,Year,MembershipTypeName,Fee,Comments,Paid")] Membership membership)
        {
            if (ModelState.IsValid)
            {
                double? fee = _context.AnnualFeeStructure.Where(y => y.Year == DateTime.Today.Year).ToList()[0].AnnualFee;
                double? percentPaid = _context.MembershipType.Where(m => m.MembershipTypeName == membership.MembershipTypeName).ToList()[0].RatioToFull;

                ViewData["fee"] = fee * percentPaid;
                membership.Fee = (double)fee * (double)percentPaid;

                _context.Add(membership);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            

            ViewData["MemberId"] = new SelectList(_context.Member, "MemberId", "FirstName", membership.MemberId);
            ViewData["MembershipTypeName"] = new SelectList(_context.MembershipType, "MembershipTypeName", "MembershipTypeName", membership.MembershipTypeName);
            return View(membership);
        }

        // GET: NSMembership/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var membership = await _context.Membership.FindAsync(id);
            if (membership == null)
            {
                return NotFound();
            }
            if(membership.Year < DateTime.Today.Year)
            {
                TempData["message"] = "Cannot edit previous year memberships";
                return RedirectToAction("Index");
            }
            ViewData["head"] = "Edit membership for "+_context.Member.Where(x => x.MemberId == membership.MemberId).ToList()[0].FullName;
            ViewData["MemberId"] = new SelectList(_context.Member.Where(x => x.MemberId.ToString() == HttpContext.Session.GetString("id")), "MemberId", "FirstName", membership.MemberId);
            ViewData["MembershipTypeName"] = new SelectList(_context.MembershipType.OrderBy(x => x.MembershipTypeName), "MembershipTypeName", "MembershipTypeName", membership.MembershipTypeName);
            return View(membership);
        }

        // POST: NSMembership/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MembershipId,MemberId,Year,MembershipTypeName,Fee,Comments,Paid")] Membership membership)
        {
            if (id != membership.MembershipId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(membership);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MembershipExists(membership.MembershipId))
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
            if (membership.Year < DateTime.Today.Year)
            {
                TempData["message"] = "Cannot edit previous year memberships";
                return RedirectToAction("Index");
            }
            ViewData["MemberId"] = new SelectList(_context.Member, "MemberId", "FirstName", membership.MemberId);
            ViewData["MembershipTypeName"] = new SelectList(_context.MembershipType, "MembershipTypeName", "MembershipTypeName", membership.MembershipTypeName);
            return View(membership);
        }

        // GET: NSMembership/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var membership = await _context.Membership
                .Include(m => m.Member)
                .Include(m => m.MembershipTypeNameNavigation)
                .FirstOrDefaultAsync(m => m.MembershipId == id);
            if (membership == null)
            {
                return NotFound();
            }
            ViewData["head"] = "Delete Membership For "+membership.Member.FullName;
            return View(membership);
        }

        // POST: NSMembership/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var membership = await _context.Membership.FindAsync(id);
            _context.Membership.Remove(membership);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MembershipExists(int id)
        {
            return _context.Membership.Any(e => e.MembershipId == id);
        }
    }
}
