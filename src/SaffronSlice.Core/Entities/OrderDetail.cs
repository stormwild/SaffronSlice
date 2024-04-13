namespace SaffronSlice.Core.Entities;

public record OrderDetailId(int Value);

public class OrderDetail
{
    public required OrderDetailId Id { get; set; }
    public required OrderId OrderId { get; set; }
    public required PizzaSku PizzaId { get; set; }
    public int Quantity { get; set; }

    public required Order Order { get; set; }
    public required Pizza Pizza { get; set; }
}

