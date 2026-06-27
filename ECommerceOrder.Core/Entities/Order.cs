namespace ECommerceOrder.Core.Entities;

public class Order : BaseEntity
{
    public int Quantity {get;set;}
    public decimal TotalAmount {get;set;}
    public int ProductId {get;set;}
    public Product Product {get;set;} = null!;
}