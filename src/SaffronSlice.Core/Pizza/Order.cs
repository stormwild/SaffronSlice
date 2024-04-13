namespace SaffronSlice.Core.Pizza;

public class Order
{
    public int Id { get; set; }
    public DateTime Date { get; set; }
    public TimeSpan Time { get; set; }

    public required ICollection<OrderDetail> OrderDetails { get; set; }
}
