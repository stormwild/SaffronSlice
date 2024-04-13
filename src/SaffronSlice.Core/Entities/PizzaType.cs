namespace SaffronSlice.Core.Entities;

public record PizzaTypeSku(string Value);
public record PizzaTypeCategory(string Category);

public class PizzaType
{
    public required PizzaTypeSku Id { get; set; }
    public required string Name { get; set; }
    public required PizzaTypeCategory Category { get; set; }
    public required string Ingredients { get; set; }

    public required List<Pizza> Pizzas { get; set; } = [];
}


