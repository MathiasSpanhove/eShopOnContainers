﻿namespace Microsoft.eShopOnContainers.Services.Ordering.Domain.AggregatesModel.OrderAggregate;

public class OrderItem
    : Entity
{
    public string ProductName { get; set; }
    public string PictureUrl { get; set; }
    public decimal UnitPrice { get; set; }
    public decimal Discount { get; set; }
    public int Units { get; set; }

    public int ProductId { get; set; }

}
