﻿/*!
 * http://www.zkea.net/
 * Copyright 2017 ZKEASOFT
 * http://www.zkea.net/licenses
 */
using Easy.MetaData;
using Easy.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ZKEACMS.Shop.Models
{
    [ViewConfigure(typeof(OrderMetaData)), Table("Order")]
    public class Order : EditorEntity
    {
        [Key]
        public string ID { get; set; }
        public string UserId { get; set; }
        public string Contact { get; set; }
        public string PhoneNumber { get; set; }
        public decimal Total { get; set; }
        public int OrderStatus { get; set; }
        public DateTime? PayTime { get; set; }
        public DateTime? CompletePayTime { get; set; }
        public string TrackingNumber { get; set; }
        public string LogisticsCompany { get; set; }
        public string ShippingAddress { get; set; }
    }
    class OrderMetaData : ViewMetaData<Order>
    {
        protected override void ViewConfigure()
        {
            ViewConfig(m => m.ID).AsHidden();
            ViewConfig(m => m.UserId).AsHidden();
            ViewConfig(m => m.Title).AsHidden();
        }
    }
}
