using System;
using BookStoreBusinessLogic.BindingModels;
using BookStoreBusinessLogic.Interfaces;
using BookStoreBusinessLogic.Enums;

namespace BookStoreBusinessLogic.BusinessLogic
{
    public class MainLogic
    {
        private readonly IOrderLogic orderLogic;

        public MainLogic(IOrderLogic orderLogic)
        {
            this.orderLogic = orderLogic;
        }

        public void CreateOrder(OrderBindingModel model)
        {
            orderLogic.CreateOrUpdate(new OrderBindingModel
            {
                CustomerID = model.CustomerID,
                PlacementDate = DateTime.Now,
                Books = model.Books,
                Status = OrderStatus.Created
            });
        }

        public void ConfirmOrder(ChangeOrderStatusBindingModel model)
        {
            var order = orderLogic.Read(new OrderBindingModel
            {
                ID = model.OrderID
            })?[0];
            if (order == null)
            {
                throw new Exception("Order not found");
            }
            if (order.Status != OrderStatus.Created)
            {
                throw new Exception("Order must have \"Created\" status");
            }
            orderLogic.CreateOrUpdate(new OrderBindingModel
            {
                ID = order.ID,
                CustomerID = order.CustomerID,
                PlacementDate = order.PlacementDate,
                Status = OrderStatus.Confirmed,
                Books = order.Books
            });
        }

        public void StartPreparingAnOrder(ChangeOrderStatusBindingModel model)
        {
            var order = orderLogic.Read(new OrderBindingModel
            {
                ID = model.OrderID
            })?[0];
            if (order == null)
            {
                throw new Exception("Order not found");
            }
            if (order.Status != OrderStatus.Confirmed)
            {
                throw new Exception("Order must have \"Confirmed\" status");
            }
            orderLogic.CreateOrUpdate(new OrderBindingModel
            {
                ID = order.ID,
                CustomerID = order.CustomerID,
                PlacementDate = order.PlacementDate,
                Status = OrderStatus.Processing,
                Books = order.Books
            });
        }

        public void CompleteOrder(ChangeOrderStatusBindingModel model)
        {
            var order = orderLogic.Read(new OrderBindingModel
            {
                ID = model.OrderID
            })?[0];
            if (order == null)
            {
                throw new Exception("Order not found");
            }
            if (order.Status != OrderStatus.Processing)
            {
                throw new Exception("Order must have \"Processing\" status");
            }
            orderLogic.CreateOrUpdate(new OrderBindingModel
            {
                ID = order.ID,
                CustomerID = order.CustomerID,
                PlacementDate = order.PlacementDate,
                Status = OrderStatus.Completed,
                Books = order.Books
            });
        }

        public void PayOrder(ChangeOrderStatusBindingModel model)
        {
            var order = orderLogic.Read(new OrderBindingModel
            {
                ID = model.OrderID
            })?[0];
            if (order == null)
            {
                throw new Exception("Order not found");
            }
            if (order.Status != OrderStatus.Completed)
            {
                throw new Exception("Order must have \"Completed\" status");
            }
            orderLogic.CreateOrUpdate(new OrderBindingModel
            {
                ID = order.ID,
                CustomerID = order.CustomerID,
                PlacementDate = order.PlacementDate,
                Status = OrderStatus.Paid,
                Books = order.Books
            });
        }
    }
}
