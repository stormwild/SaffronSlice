namespace SaffronSlice.Core.Entities;

public record OrderId(int Value);

public class Order
{
    public required OrderId Id { get; set; }
    public DateTime Created { get; set; }

    public required List<OrderDetail> OrderDetails { get; set; } = [];
}
