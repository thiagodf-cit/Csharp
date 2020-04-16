using System;
using InfoProduct.Entities;
using InfoProduct.Entities.Enums;

namespace InfoProduct
{
    public class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();
    	public List<Client> Client {get; set; } = new List<Client>();

        public Order()
        {
        }

        public Order(DateTime moment, OrderStatus status)
        {
            Moment = moment;
            Status = status;
        }

        public void AddItem(OrderItem item)
        {

        }
        public void RemoveItem(OderItem item)
        {

        }
        public double Total()
        {
            
        }
    }
}