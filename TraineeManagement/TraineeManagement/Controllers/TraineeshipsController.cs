using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TraineeManagement.Data;

namespace TraineeManagement.Controllers
{
    public class TraineeshipsController : Controller
    {
        private readonly TraineeManagementContext _context;

        public TraineeshipsController(TraineeManagementContext context)
        {
            _context = context;
        }

        // GET: Traineeships
        public async Task<IActionResult> Index()
        {
            var traineeManagementContext = _context.TraineeShips.Include(t => t.Trainee);
            return View(await traineeManagementContext.ToListAsync());
        }

        // GET: Traineeships/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var traineeship = await _context.TraineeShips
                .Include(t => t.Trainee)
                .SingleOrDefaultAsync(m => m.Id == id);
            if (traineeship == null)
            {
                return NotFound();
            }

            return View(traineeship);
        }

        // GET: Traineeships/Create
        public IActionResult Create()
        {
            ViewData["TraineeId"] = new SelectList(_context.Trainees, "Id", "Id");
            return View();
        }

        // POST: Traineeships/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,BeginDate,EndDate,TraineeId")] Traineeship traineeship)
        {
            if (ModelState.IsValid)
            {
                _context.Add(traineeship);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["TraineeId"] = new SelectList(_context.Trainees, "Id", "Id", traineeship.TraineeId);
            return View(traineeship);
        }

        // GET: Traineeships/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var traineeship = await _context.TraineeShips.SingleOrDefaultAsync(m => m.Id == id);
            if (traineeship == null)
            {
                return NotFound();
            }
            ViewData["TraineeId"] = new SelectList(_context.Trainees, "Id", "Id", traineeship.TraineeId);
            return View(traineeship);
        }

        // POST: Traineeships/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,BeginDate,EndDate,TraineeId")] Traineeship traineeship)
        {
            if (id != traineeship.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(traineeship);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TraineeshipExists(traineeship.Id))
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
            ViewData["TraineeId"] = new SelectList(_context.Trainees, "Id", "Id", traineeship.TraineeId);
            return View(traineeship);
        }

        // GET: Traineeships/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var traineeship = await _context.TraineeShips
                .Include(t => t.Trainee)
                .SingleOrDefaultAsync(m => m.Id == id);
            if (traineeship == null)
            {
                return NotFound();
            }

            return View(traineeship);
        }

        // POST: Traineeships/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var traineeship = await _context.TraineeShips.SingleOrDefaultAsync(m => m.Id == id);
            _context.TraineeShips.Remove(traineeship);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TraineeshipExists(int id)
        {
            return _context.TraineeShips.Any(e => e.Id == id);
        }
    }
}
