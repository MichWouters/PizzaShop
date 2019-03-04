using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PizzaShop.Business.Models;
using PizzaShop.Business.Services;
using PizzaShop.Data;
using PizzaShop.Data.Entities;
using PizzaShop.ViewModels;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaShop.Controllers
{
    public class PizzasController : Controller
    {
        // Todo: Remove
        private readonly ApplicationDbContext _context;
        private readonly IPizzaService _pizzaService;
        private readonly IMapper _mapper;

        public PizzasController(ApplicationDbContext context, IPizzaService service, IMapper mapper)
        {
            _context = context;
            _pizzaService = service;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Pizzas.ToListAsync());
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            PizzaModel model = await _pizzaService.GetPizzaWithIngredientsAsync((int)id);
            PizzaDetailViewModel viewModel = new PizzaDetailViewModel();
            viewModel = _mapper.Map(model, viewModel);

            if (viewModel == null)
            {
                return NotFound();
            }

            return View(viewModel);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PizzaId,Name,Image,Price,Description,Ingredients")] PizzaDetailViewModel pizza)
        {
            if (ModelState.IsValid)
            {
                PizzaModel pizzaModel = _mapper.Map<PizzaModel>(pizza);
                await _pizzaService.SavePizza(pizzaModel);

                return RedirectToAction(nameof(Index));
            }
            return View(pizza);
        }

        // GET: Pizzas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pizza = await _context.Pizzas.FindAsync(id);
            if (pizza == null)
            {
                return NotFound();
            }
            return View(pizza);
        }

        // POST: Pizzas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PizzaId,Name,Image,Price,DateCreated,DateModified,ModifiedBy")] Pizza pizza)
        {
            if (id != pizza.PizzaId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pizza);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PizzaExists(pizza.PizzaId))
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
            return View(pizza);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pizza = await _context.Pizzas
                .FirstOrDefaultAsync(m => m.PizzaId == id);
            if (pizza == null)
            {
                return NotFound();
            }

            return View(pizza);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var pizza = await _context.Pizzas.FindAsync(id);
            _context.Pizzas.Remove(pizza);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PizzaExists(int id)
        {
            return _context.Pizzas.Any(e => e.PizzaId == id);
        }
    }
}