using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PizzaShop.Data.Entities;
using System;

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
                new Ingredient { IngredientId = 1, Name = "Tomato", IsVegetarian = true, Type = IngredientType.Fruit, DateCreated = DateTime.Now, },
                new Ingredient { IngredientId = 2, Name = "Mozarella", IsVegetarian = true, Type = IngredientType.Cheese, DateCreated = DateTime.Now },
                new Ingredient { IngredientId = 3, Name = "Salami", IsVegetarian = false, Type = IngredientType.Meat, DateCreated = DateTime.Now },
                new Ingredient { IngredientId = 4, Name = "Thyme", IsVegetarian = true, Type = IngredientType.Condiments, DateCreated = DateTime.Now.ToUniversalTime() },
                new Ingredient { IngredientId = 5, Name = "Chicken", IsVegetarian = false, Type = IngredientType.Meat, DateCreated = DateTime.Now },
                new Ingredient { IngredientId = 6, Name = "Anchovie", IsVegetarian = true, Type = IngredientType.Fish, DateCreated = DateTime.Now },
                new Ingredient { IngredientId = 7, Name = "Onion", IsVegetarian = true, Type = IngredientType.Vegetables, DateCreated = DateTime.Now },
                new Ingredient { IngredientId = 8, Name = "BBQ Sauce", IsVegetarian = true, Type = IngredientType.Sauce, DateCreated = DateTime.Now }
                );

            builder.Entity<Pizza>().HasData(
                new Pizza { PizzaId = 1, Name = "Margherita", Price = 4.99, Description = "The traditional toppings on a Margherita pizza are fresh basil, fresh tomatoes, olive oil, sea salt, garlic, and mozzarella. Typically, the tomatoes are sliced and scattered across the dough before finely chopped garlic and basil are sprinkled on, followed by rounds of thinly sliced cheese. The pizza is drizzled lightly with olive oil and sea salt just before baking, and when well made, it is crisp without any trace of greasiness." },
                new Pizza { PizzaId = 2, Name = "Pepperoni", Price = 6.99, Description = "If you've ever wished your pepperoni pizza had more pepperoni on it, then this pizza is for you! This oven-fresh pizza has 50% more pepperoni than our average pizza pie."},
                new Pizza { PizzaId = 3, Name = "Meat Lovers", Price = 8.99, Description = "Meat lover's pizza is the perfect game day pizza, packed with pepperoni, Italian sausage, ham, bacon, season pork and beef." }
                );

            builder.Entity<PizzaIngredient>().HasData(
                new PizzaIngredient { Id = 1, PizzaId = 1, IngredientId = 1 },
                new PizzaIngredient { Id = 2, PizzaId = 1, IngredientId = 2 },

                new PizzaIngredient { Id = 3, PizzaId = 2, IngredientId = 1 },
                new PizzaIngredient { Id = 4, PizzaId = 2, IngredientId = 2 },
                new PizzaIngredient { Id = 5, PizzaId = 2, IngredientId = 3 },

                new PizzaIngredient { Id = 6, PizzaId = 3, IngredientId = 1 },
                new PizzaIngredient { Id = 7, PizzaId = 3, IngredientId = 2 },
                new PizzaIngredient { Id = 8, PizzaId = 3, IngredientId = 3 },
                new PizzaIngredient { Id = 9, PizzaId = 3, IngredientId = 4 },
                new PizzaIngredient { Id = 10, PizzaId = 3, IngredientId = 5 }
                );
        }
    }
}