﻿using ReStore.Domain.Enums;

namespace ReStore.Domain.Entities;

public class Order
{
     public int Id { get; set; }
     public string BuyerId { get; set; }
     public ShippingAddress ShippingAddress { get; set; }
     public DateTime OrderDate { get; set; } = DateTime.Now;
     public List<OrderItem> OrderItems { get; set; }
     public long Subtotal { get; set; }
     public long DeliveryFee { get; set; }
     public OrderStatus OrderStatus { get; set; } = OrderStatus.Pending;

     // for payment
     public string PaymentIntentId { get; set; }

     public long GetTotal()
     {
          return Subtotal + DeliveryFee;
     }
}
