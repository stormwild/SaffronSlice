namespace SaffronSlice.Core.Pizza;

public class OrderDetail
{
    public int Id { get; set; }
    public int OrderId { get; set; }
    public int PizzaId { get; set; }
    public int Quantity { get; set; }

    public required Order Order { get; set; }
    public required Pizza Pizza { get; set; }
}