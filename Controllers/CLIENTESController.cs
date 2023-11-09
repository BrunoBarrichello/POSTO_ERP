using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using POSTO_ERP.Models;

namespace POSTO_ERP.Controllers
{
    public class CLIENTESController : Controller
    {
        private readonly Contexto _context;

        public CLIENTESController(Contexto context)
        {
            _context = context;
        }

        // GET: CLIENTES
        public async Task<IActionResult> Index()
        {
              return _context.Cliente != null ? 
                          View(await _context.Cliente.ToListAsync()) :
                          Problem("Entity set 'Contexto.Cliente'  is null.");
        }

        // GET: CLIENTES/Details/5
        public async Task<IActionResult> Details(string? id)
        {
            if (id == null || _context.Cliente == null)
            {
                return NotFound();
            }

            var cLIENTES = await _context.Cliente
                .FirstOrDefaultAsync(m => m.CNPJ_CPF == id);
            if (cLIENTES == null)
            {
                return NotFound();
            }

            return View(cLIENTES);
        }

        // GET: CLIENTES/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CLIENTES/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CNPJ_CPF,CODIGO")] CLIENTES cLIENTES)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cLIENTES);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cLIENTES);
        }

        // GET: CLIENTES/Edit/5
        public async Task<IActionResult> Edit(string? id)
        {
            if (id == null || _context.Cliente == null)
            {
                return NotFound();
            }

            var cLIENTES = await _context.Cliente.FindAsync(id);
            if (cLIENTES == null)
            {
                return NotFound();
            }
            return View(cLIENTES);
        }

        // POST: CLIENTES/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("CNPJ_CPF,CODIGO")] CLIENTES cLIENTES)
        {
            if (id != cLIENTES.CNPJ_CPF)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cLIENTES);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CLIENTESExists(cLIENTES.CNPJ_CPF))
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
            return View(cLIENTES);
        }

        // GET: CLIENTES/Delete/5
        public async Task<IActionResult> Delete(string? id)
        {
            if (id == null || _context.Cliente == null)
            {
                return NotFound();
            }

            var cLIENTES = await _context.Cliente
                .FirstOrDefaultAsync(m => m.CNPJ_CPF == id);
            if (cLIENTES == null)
            {
                return NotFound();
            }

            return View(cLIENTES);
        }

        // POST: CLIENTES/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.Cliente == null)
            {
                return Problem("Entity set 'Contexto.Cliente'  is null.");
            }
            var cLIENTES = await _context.Cliente.FindAsync(id);
            if (cLIENTES != null)
            {
                _context.Cliente.Remove(cLIENTES);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CLIENTESExists(string id)
        {
          return (_context.Cliente?.Any(e => e.CNPJ_CPF == id)).GetValueOrDefault();
        }
    }
}
