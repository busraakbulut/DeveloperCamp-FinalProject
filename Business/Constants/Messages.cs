using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Core.Entities.Concrete;

namespace Business.Constants
{
    public static class Messages // static yapıların newlenmeye ihtiyacı yoktur.
    {
        public static string ProductAdded = "Product Added!";
        public static string ProductNameInvalid = "Product Name Invalid! ";
        public static string ProductsListed = "All Products Listed!";
        public static string MaintenanceTime = "Under Maintenance";
        public static string ProductCountOfCategoryError = "There are more than 10 products in the category!";
        public static string ProductNameAlreadyExists = "Product Name Already Exists.Try Another Name!";
        public static string CategoryLimitExceed = "Category Limit Exceed!";
        public static string AuthorizationDenied = "Authorization Denied!";
        public static string UserRegistered = "Registered!";
        public static string UserNotFound = "User Not Found!";
        public static string PasswordError = "Password Error!";
        public static string SuccessfulLogin = " Login Succefully!";
        public static string UserAlreadyExists = "User Already Exists. Try Another Username!";
        public static string AccessTokenCreated = " Access Token Created!";
    }
}
