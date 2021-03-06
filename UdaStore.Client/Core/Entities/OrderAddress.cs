﻿using System;
using System.Collections.Generic;

namespace UdaStore.Client.Core.Entities
{
    public partial class OrderAddress
    {
        public OrderAddress()
        {
            OrdersOrderBillingAddress = new HashSet<Order>();
            OrdersOrderShippingAddress = new HashSet<Order>();
        }

        public long Id { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string ContactName { get; set; }
        public long CountryId { get; set; }
        public long DistrictId { get; set; }
        public string Phone { get; set; }
        public long StateOrProvinceId { get; set; }

        public Country Country { get; set; }
        public District District { get; set; }
        public StateOrProvince StateOrProvince { get; set; }
        public ICollection<Order> OrdersOrderBillingAddress { get; set; }
        public ICollection<Order> OrdersOrderShippingAddress { get; set; }
    }
}
