using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string GetCarsByBrandId = "Cars listed to Brand Id";
        public static string GetCarsByColorId = "Cars listed to Color Id";
        public static string CarAdded = "Car added to list";
        public static string CarDeleted = "Car deleted to list";
        public static string CarUpdated = "Car updated";
        public static string CarProductNameInvalid = "Car name invalid";
        public static string CarListed = "Car listed";
        public static string CarDetailListed = "Car details listed";
        public static string SystemMaintenanceTime = "System in maintenance";
        public static string Added = "Added";
        public static string Deleted = "Deleted";
        public static string Updated = "Updated";
        public static string Getid = "Get by id";
        public static string Listed = "Listed";
        public static string GetAll = "Listed to all data";
        public static string RentalInValid = "Rental Failed";
        public static string RentalSuccess = "Rental Success";
        public static string UserAdded = "User added";
        public static string UserNotFound = "User not found";
        public static string PasswordError = "Password error";
        public static string SuccessfulLogin = "Successful login";
        public static string UserAlreadyExists = "User already exists";
        public static string UserRegistered = "User registered";
        public static string AccessTokenCreated ="Access Token Created";
        public static string AuthorizationDenied ="Authorization Denied";
        public static string GetRentalDetails = "Listed to Rental Details";
    }
}
