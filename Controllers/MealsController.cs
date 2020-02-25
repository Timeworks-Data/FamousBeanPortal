using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FamousBeanPortal.Data;
using FamousBeanPortal.Models;

namespace FamousBeanPortal.Controllers
{
    public class MealsController : Controller
    {
        private readonly FamousContext _context;

        public MealsController(FamousContext context)
        {
            _context = context;
        }

        // GET: Meals
        public async Task<IActionResult> Index()
        {
            return View(await _context.Meal.ToListAsync());
        }

        // GET: Meals/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var meal = await _context.Meal
                .FirstOrDefaultAsync(m => m.Id == id);
            if (meal == null)
            {
                return NotFound();
            }

            return View(meal);
        }

        // GET: Meals/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Meals/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,MealId,CategoryId,MealName,Price,Description,NutritionValues,Status")] Meal meal)
        {
            if (ModelState.IsValid)
            {
                _context.Add(meal);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(meal);
        }

        // GET: Meals/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var meal = await _context.Meal.FindAsync(id);
            if (meal == null)
            {
                return NotFound();
            }
            return View(meal);
        }

        // POST: Meals/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Id,MealId,CategoryId,MealName,Price,Description,NutritionValues,Status")] Meal meal)
        {
            if (id != meal.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(meal);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MealExists(meal.Id))
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
            return View(meal);
        }

        // GET: Meals/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var meal = await _context.Meal
                .FirstOrDefaultAsync(m => m.Id == id);
            if (meal == null)
            {
                return NotFound();
            }

            return View(meal);
        }

        // POST: Meals/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var meal = await _context.Meal.FindAsync(id);
            _context.Meal.Remove(meal);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MealExists(string id)
        {
            return _context.Meal.Any(e => e.Id == id);
        }
    }
}
