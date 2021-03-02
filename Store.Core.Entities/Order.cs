﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Store.Core.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int ProductId { get; set; }
        public int QuantityOrder { get; set; }
        public string Status { get; set; } = "new";
        public DateTime Date { get; set; }
        public decimal TotalPrice { get; set; }

        private List<OrderItem> items;

        public IReadOnlyCollection<OrderItem> Items
        {
            get { return items; }
        }

        public int TotalCount
        {
            get { return items.Sum(item => item.Count); }
        }

        public Order(int id, IEnumerable<OrderItem> items)
        {
            if (items == null)
            {
                throw new ArgumentNullException(nameof(items));
            }
            Id = id;
            this.items = new List<OrderItem>(items);
        }

        public Order()
        {
        }

        public void AddItem(Product product, int count)
        {
            if (product == null)
            {
                throw new ArgumentNullException(nameof(product));
            }

            var item = items.SingleOrDefault(x => x.ProductId == product.Id);
            if (item == null)
            {
                items.Add(new OrderItem(product.Id, count, product.Price));
            }
            else
            {
                items.Remove(item);
                items.Add(new OrderItem(product.Id, item.Count + count, product.Price));
            }
        }
    }
}
