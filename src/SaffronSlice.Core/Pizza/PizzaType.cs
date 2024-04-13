namespace SaffronSlice.Core.Pizza;

public class PizzaType
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public required string Category { get; set; }
    public required string Ingredients { get; set; }

    public required ICollection<Pizza> Pizzas { get; set; }
}
