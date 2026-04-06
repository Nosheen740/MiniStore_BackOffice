using App.Core.Models;
using App.Core.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Core.Contracts
{
    public interface IOrderService
    {
        public List<Order> GetAll();
        public Order GetById(string id);
        public void Add(Order order);
        public void Update(Order order);
        public void Delete(string id);
        public List<Order> GetByCustomerId(string CustomerId);
        public List<Order> GetByStatus(OrderStatusEnum status);
    }
}
