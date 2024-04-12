namespace Discount.Grpc.Models;

public class Coupon
{
    public int Id { get; set; }
    public string ProductName { get; set; } = default!; //TODO: Can I change it to ID
    public string Description { get; set; } = default!;
    public int Amount { get; set; }
}
