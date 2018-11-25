using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PizzaShop.Data.Entities;
using PizzaShop.Enums;

namespace PizzaShop.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            SeedData(builder);
        }

        // Database Tables
        public DbSet<Customer> Customers { get; set; }

        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Pizza> Pizzas { get; set; }
        public DbSet<PizzaIngredient> PizzaIngredients { get; set; }

        // Fill Database with sample data
        private void SeedData(ModelBuilder builder)
        {
            builder.Entity<Ingredient>().HasData(
                new Ingredient { IngredientId = 1, Name = "Tomato", IsVegetarian = true, Type = (int)IngredientCategory.Fruit },
                new Ingredient { IngredientId = 2, Name = "Olives", IsVegetarian = true, Type = (int)IngredientCategory.Fruit },
                new Ingredient { IngredientId = 3, Name = "Mozarella", IsVegetarian = true, Type = (int)IngredientCategory.Cheese },
                new Ingredient { IngredientId = 4, Name = "Gouda", IsVegetarian = true, Type = (int)IngredientCategory.Cheese },
                new Ingredient { IngredientId = 5, Name = "Parmesan", IsVegetarian = true, Type = (int)IngredientCategory.Cheese },
                new Ingredient { IngredientId = 6, Name = "Salami", IsVegetarian = false, Type = (int)IngredientCategory.Meat },
                new Ingredient { IngredientId = 7, Name = "Bacon", IsVegetarian = false, Type = (int)IngredientCategory.Meat },
                new Ingredient { IngredientId = 8, Name = "Meringue", IsVegetarian = false, Type = (int)IngredientCategory.Meat },
                new Ingredient { IngredientId = 9, Name = "Chicken", IsVegetarian = false, Type = (int)IngredientCategory.Meat },
                new Ingredient { IngredientId = 10, Name = "Thyme", IsVegetarian = true, Type = (int)IngredientCategory.Condiments },
                new Ingredient { IngredientId = 11, Name = "Pepper", IsVegetarian = true, Type = (int)IngredientCategory.Condiments },
                new Ingredient { IngredientId = 12, Name = "Salt", IsVegetarian = true, Type = (int)IngredientCategory.Condiments },
                new Ingredient { IngredientId = 13, Name = "Anchovies", IsVegetarian = true, Type = (int)IngredientCategory.Fish },
                new Ingredient { IngredientId = 14, Name = "Salmon", IsVegetarian = true, Type = (int)IngredientCategory.Fish },
                new Ingredient { IngredientId = 15, Name = "Squid", IsVegetarian = true, Type = (int)IngredientCategory.Fish },
                new Ingredient { IngredientId = 16, Name = "Onion", IsVegetarian = true, Type = (int)IngredientCategory.Vegetables },
                new Ingredient { IngredientId = 17, Name = "Green peppers", IsVegetarian = true, Type = (int)IngredientCategory.Vegetables },
                new Ingredient { IngredientId = 18, Name = "BBQ Sauce", IsVegetarian = true, Type = (int)IngredientCategory.Sauce },
                new Ingredient { IngredientId = 19, Name = "Olive Oil", IsVegetarian = true, Type = (int)IngredientCategory.Sauce },
                new Ingredient { IngredientId = 20, Name = "Vinegar", IsVegetarian = true, Type = (int)IngredientCategory.Sauce }
                );

            builder.Entity<Pizza>().HasData(
                new Pizza { PizzaId = 1, Name = "Margarita", Price = 4.99M, Image = "margarita.jpg", Description = "The traditional toppings on a Margherita pizza are fresh basil, fresh tomatoes, olive oil, sea salt, garlic, and mozzarella. Typically, the tomatoes are sliced and scattered across the dough before finely chopped garlic and basil are sprinkled on, followed by rounds of thinly sliced cheese. The pizza is drizzled lightly with olive oil and sea salt just before baking, and when well made, it is crisp without any trace of greasiness." },
                new Pizza { PizzaId = 2, Name = "Pepperoni", Price = 6.99M, Image = "pepperoni.jpg", Description = "If you've ever wished your pepperoni pizza had more pepperoni on it, then this pizza is for you! This oven-fresh pizza has 50% more pepperoni than our average pizza pie." },
                new Pizza { PizzaId = 3, Name = "Meat Lovers", Price = 8.99M, Image = "meat-lovers.jpg", Description = "Meat lover's pizza is the perfect game day pizza, packed with pepperoni, Italian sausage, ham, bacon, season pork and beef." }
                );

            builder.Entity<PizzaIngredient>().HasData(
                new PizzaIngredient { Id = 1, PizzaId = 1, IngredientId = 1 },
                new PizzaIngredient { Id = 2, PizzaId = 1, IngredientId = 2 },
                new PizzaIngredient { Id = 3, PizzaId = 1, IngredientId = 3 },
                new PizzaIngredient { Id = 4, PizzaId = 1, IngredientId = 19 },

                new PizzaIngredient { Id = 5, PizzaId = 2, IngredientId = 1 },
                new PizzaIngredient { Id = 6, PizzaId = 2, IngredientId = 2 },
                new PizzaIngredient { Id = 7, PizzaId = 2, IngredientId = 3 },
                new PizzaIngredient { Id = 8, PizzaId = 2, IngredientId = 6 },
                new PizzaIngredient { Id = 9, PizzaId = 2, IngredientId = 11 },
                new PizzaIngredient { Id = 10, PizzaId = 2, IngredientId = 19 },

                new PizzaIngredient { Id = 11, PizzaId = 3, IngredientId = 1 },
                new PizzaIngredient { Id = 12, PizzaId = 3, IngredientId = 2 },
                new PizzaIngredient { Id = 13, PizzaId = 3, IngredientId = 3 },
                new PizzaIngredient { Id = 14, PizzaId = 3, IngredientId = 6 },
                new PizzaIngredient { Id = 15, PizzaId = 3, IngredientId = 7 },
                new PizzaIngredient { Id = 16, PizzaId = 3, IngredientId = 8 },
                new PizzaIngredient { Id = 17, PizzaId = 3, IngredientId = 17 },
                new PizzaIngredient { Id = 18, PizzaId = 3, IngredientId = 19 },
                new PizzaIngredient { Id = 19, PizzaId = 3, IngredientId = 20 }
                );
        }
    }
}