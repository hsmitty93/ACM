namespace ACM.BL
{
    public class ProductRepository
    {
        // Collaboration relationship
        public Product Retrieve(int productId)
        {
            //Create the instance of the Product class
            //Pass in the requested Id
            Product product = new Product(productId);

            //Code that retrieves the defined product

            //Temp hard-coded values to return a populated product
            if (productId == 1)
            {
                product.ProductName = "Chair";
                product.ProductDescription = "Something you can sit on";
                product.CurrentPrice = 10;
            }
            return product;
        }

        public bool Save(Product product)
        {
            var success = true;

            if (product.HasChanges)
            {
                if (product.isValid)
                {
                    if (product.IsNew)
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