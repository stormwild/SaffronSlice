namespace SaffronSlice.Core.Entities;

public enum PizzaSizeType
{
    S,
    M,
    L
}

public record PizzaSku(string Value);
public record PizzaSize(PizzaSizeType Size);

public class Pizza
{
    public required PizzaSku Id { get; set; }
    public required PizzaTypeSku PizzaTypeId { get; set; }
    public required PizzaSize Size { get; set; }
    public decimal Price { get; set; }

    public required PizzaType PizzaType { get; set; }
}
