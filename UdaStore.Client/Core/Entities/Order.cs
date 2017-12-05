using System;
using System.Collections.Generic;

namespace UdaStore.Client.Core.Entities
{
    public partial class Order
    {
        public Order()
        {
            InverseParent = new HashSet<Order>();
            OrdersOrderItem = new HashSet<OrderItem>();
        }

        public long Id { get; set; }
        public long BillingAddressId { get; set; }
        public long CreatedById { get; set; }
        public DateTimeOffset CreatedOn { get; set; }
        public int OrderStatus { get; set; }
        public long? ParentId { get; set; }
        public long ShippingAddressId { get; set; }
        public decimal SubTotal { get; set; }
        public DateTimeOffset? UpdatedOn { get; set; }
        public long? VendorId { get; set; }

        public OrderAddress BillingAddress { get; set; }
        public User CreatedBy { get; set; }
        public Order Parent { get; set; }
        public OrderAddress ShippingAddress { get; set; }
        public ICollection<Order> InverseParent { get; set; }
        public ICollection<OrderItem> OrdersOrderItem { get; set; }
    }
}
