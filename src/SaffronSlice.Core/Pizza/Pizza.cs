namespace SaffronSlice.Core.Pizza;

public class Pizza
{
    public int Id { get; set; }
    public int PizzaTypeId { get; set; }
    public required string Size { get; set; }
    public decimal Price { get; set; }

    public required PizzaType PizzaType { get; set; }
}
