using System;
using System.Collections.Generic;
using Acme.Common;

namespace ACM.BL
{
    public class Product : EntityBase, ILoggable
    {
        public Product()
        {

        }

        public Product(int productId)
        {
            ProductId = productId;
        }
        public string ProductName 
        { 
            get
            {
                return _productName.InsertSpaces();
            } 
            set
            {
                _productName = value;
            } 
        }
        public int ProductId { get; private set; }
        public string ProductDescription { get; set; }
        public decimal? CurrentPrice { get; set; }
        public override string ToString() => ProductName;
        private string _productName;

        public string Log() => $"{ProductId}: {ProductName} Detail: {ProductDescription} Status: {EntityState.ToString()}";
        public override bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (CurrentPrice == null) isValid = false;

            return isValid;
        }
    }
}