namespace SaffronSlice.Core.Entities;

public record OrderId(int Id);

public class Order
{
    public required OrderId Id { get; set; }
    public DateTime Created { get; set; }

    public required ICollection<OrderDetail> OrderDetails { get; set; } = [];
}
