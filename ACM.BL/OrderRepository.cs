using System;

namespace ACM.BL
{
    public class OrderRepository
    {
        // Collaboration Relationship
        public Order Retrieve(int orderId)
        {
            //Create the instance of the Order class
            //Pass in the requested Id
            Order order = new Order(orderId);

            //Code that retrieves the defined order

            //Temp hard-coded values to return a populated order
            if (orderId == 1)
            {
                order.OrderDate = new DateTimeOffset(2020, 10, 10, 12, 23, 04, TimeSpan.Zero);
            }
            return order;
        }

        public bool Save(Order order)
        {
            var success = true;

            if (order.HasChanges)
            {
                if (order.isValid)
                {
                    if (order.IsNew)
                    {
                        // Call an Insert Stroed Procedure
                    }
                    else
                    {
                        //Call an update Stored Procedure
                    }
                }
                else
                {
                    success = false;
                }
            }
            return success;
        }
    }
}