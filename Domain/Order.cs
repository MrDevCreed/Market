﻿using System;
using System.Collections.Generic;

namespace Domain
{
    public class Order
    {
        public Order() { }
        public Order(List<OrderProduct> orderProducts, Customer customer, Seller seller)
        {
            this.OrderProducts = orderProducts;
            this.OrderState = OrderState.AwaitingConfirmation;
            this.CreatedAt = DateTime.UtcNow;
            this.Customer = customer;
            this.Seller = seller;
        }

        public int Id { get; private set; }

        public virtual List<OrderProduct> OrderProducts { get; private set; }

        public virtual OrderState OrderState { get; private set; }

        public DateTime CreatedAt { get; private set; }

        public virtual Customer Customer { get; private set; }

        public virtual Seller Seller { get; private set; }

        //Functions

        public void ChangeOrderState(OrderState orderState)
        {
            this.OrderState = orderState;
        }
    }
}
