using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "The product is added";
        public static string ProductNameInvalid = "The product name is invalid";
        public static string MaintenanceTime = "The system is under maintenance";
        public static string ProductsListed = "The products is listed";
        public static string UnitPriceInvalid = "Unit price of the product is invalid";
        public static string ProductCountOfCategoryError = "There can be a maximum of 10 products in a category.";
        public static string ProductNameAlreadyExistsError = "This product name is already available.";
        public static string CategoryMaxCountError = "Max category count is must be 15";
    }
}
