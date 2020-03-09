using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CitelProject.MVC.Extensions
{
    public class APIExtension
    {
        public string URL_BASE { get; private set; }
        public string CATEGORIES = "api/categories";
        public string PRODUCTS = "api/products";

        public APIExtension()
        {
            URL_BASE = "http://localhost/CitelProjectAPI/";
        }
    }
}