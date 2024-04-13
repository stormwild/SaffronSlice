using Microsoft.EntityFrameworkCore;

using SaffronSlice.Core.Entities;
using SaffronSlice.Infrastructure.Persistence;

namespace SaffronSlice.Api.Endpoints;

public static class PizzaEndpoints
{
    public static void MapEndpoints(WebApplication app)
    {
        app.MapGet("/pizzas", async (AppDbContext db) =>
        {
            var pizzas = await db.Pizzas.ToListAsync();
            return Results.Ok(pizzas);
        });

        app.MapGet("/pizzas/{id}", async (AppDbContext db, int id) =>
        {
            var pizza = await db.Pizzas.FindAsync(id);
            return pizza is not null ? Results.Ok(pizza) : Results.NotFound();
        });

        app.MapPost("/pizzas", async (AppDbContext db, Pizza pizza) =>
        {
            db.Pizzas.Add(pizza);
            await db.SaveChangesAsync();
            return Results.Created($"/pizzas/{pizza.Id}", pizza);
        });

        app.MapPut("/pizzas/{id}", async (AppDbContext db, string id, Pizza pizza) =>
        {
            if (id != pizza.Id.Value)
            {
                return Results.BadRequest("Id mismatch");
            }

            db.Entry(pizza).State = EntityState.Modified;
            await db.SaveChangesAsync();
            return Results.Ok(pizza);
        });

        app.MapDelete("/pizzas/{id}", async (AppDbContext db, string id) =>
        {
            var pizza = await db.Pizzas.FindAsync(id);
            if (pizza is null)
            {
                return Results.NotFound();
            }

            db.Pizzas.Remove(pizza);
            await db.SaveChangesAsync();
            return Results.NoContent();
        });
    }

}
