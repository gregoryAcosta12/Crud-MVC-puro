namespace Northwind.Web.Models.Response
{
    public class ProductsListResponse
    {
        public bool success { get; set; }
        public object? message { get; set; }
        public List<ProductsViewResult>? data { get; set; }

    }

    public class ProductsViewResult
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
<<<<<<< HEAD

        public string QuantityPerUnit { get; set; }
        public decimal? UnitPrice { get; set; }
        public short? UnitsInStock { get; set; }

    }




}
=======
        public int? SupplierID { get; set; }
        public int? CategoryID { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal? UnitPrice { get; set; }
        public short? UnitsInStock { get; set; }
        public short? UnitsOnOrder { get; set; }
        public short? ReorderLevel { get; set; }
        public bool Discontinued { get; set; }
    }
}

>>>>>>> 27810b607528a82277bd7f871bd8969b136687a7
