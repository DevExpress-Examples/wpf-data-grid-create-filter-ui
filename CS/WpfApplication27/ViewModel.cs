using DevExpress.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using DevExpress.Utils.Filtering;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WpfApplication27
{
    public class ViewModel
    {
        public BindingList<Order> Orders { get; set; }
        public ViewModel()
        {
            Orders = new BindingList<Order>();
            GetOrders();
            CategoryNames = new string[] { "Beverages", "Condiments", "Confections", "Dairy Products", "Grains / Cereals", "Meat / Poultry", "Produce", "Seafood" };
            Cities = new string[] { "Aachen", "Barcelona", "London" };
            MaxUnitPrice = Orders.Max(m => m.UnitPrice);
            MinUnitPrice = Orders.Min(m => m.UnitPrice);
            MaxDiscount = Orders.Max(m => m.Discount);
            MinDiscount = Orders.Min(m => m.Discount);
            MinFreight = Orders.Min(m => m.Freight);
            MaxFreight = Orders.Max(m => m.Freight);
            MinQuantity = Orders.Min(m => m.Quantity);
            MaxQuantity = Orders.Max(m => m.Quantity);
        }
        public string[] Cities { get; private set; }
        public string[] CategoryNames { get; private set; }
        public double MinUnitPrice { get; private set; }
        public double MaxUnitPrice { get; private set; }
        public double MinDiscount { get; private set; }
        public double MaxDiscount { get; private set; }
        public double MinFreight { get; private set; }
        public double MaxFreight { get; private set; }
        public int MinQuantity { get; private set; }
        public int MaxQuantity { get; private set; }

        private void GetOrders()
        {
            #region SetData
            Orders.Add(new Order() { City = "Aachen", UnitPrice = 10, Quantity = 20, Discount = 0, Freight = 30.54, Product = new Product() { ProductName = "Chai", CategoryName = "Beverages" } });
            Orders.Add(new Order() { City = "Aachen", UnitPrice = 6.20, Quantity = 12, Discount = 0, Freight = 30.54, Product = new Product() { ProductName = "Chang", CategoryName = "Beverages" } });
            Orders.Add(new Order() { City = "Aachen", UnitPrice = 14.40, Quantity = 12, Discount = 2, Freight = 30.54, Product = new Product() { ProductName = "Aniseed Syrup", CategoryName = "Condiments" } });
            Orders.Add(new Order() { City = "Aachen", UnitPrice = 4.80, Quantity = 18, Discount = 0, Freight = 4.45, Product = new Product() { ProductName = "Chef Anton's Cajun Seasoning", CategoryName = "Condiments" } });
            Orders.Add(new Order() { City = "Aachen", UnitPrice = 21, Quantity = 20, Discount = 3, Freight = 33.35, Product = new Product() { ProductName = "Chef Anton's Gumbo Mix", CategoryName = "Condiments" } });
            Orders.Add(new Order() { City = "Aachen", UnitPrice = 6, Quantity = 7, Discount = 0, Freight = 149.74, Product = new Product() { ProductName = "Grandma's Boysenberry Spread", CategoryName = "Condiments" } });

            Orders.Add(new Order() { City = "Barcelona", UnitPrice = 16.80, Quantity = 5, Discount = 0, Freight = 10.14, Product = new Product() { ProductName = "Uncle Bob's Organic Dried Pears", CategoryName = "Produce" } });
            Orders.Add(new Order() { City = "Barcelona", UnitPrice = 6.20, Quantity = 45, Discount = 0, Freight = 10.14, Product = new Product() { ProductName = "Northwoods Cranberry Sauce", CategoryName = "Condiments" } });
            Orders.Add(new Order() { City = "Barcelona", UnitPrice = 14.40, Quantity = 5, Discount = 6, Freight = 18.69, Product = new Product() { ProductName = "Mishi Kobe Niku", CategoryName = "Meat/Poultry" } });
            Orders.Add(new Order() { City = "Barcelona", UnitPrice = 4.80, Quantity = 17, Discount = 0, Freight = 18.69, Product = new Product() { ProductName = "Ikura", CategoryName = "Seafood" } });
            Orders.Add(new Order() { City = "Barcelona", UnitPrice = 21, Quantity = 35, Discount = 0, Freight = 6.54, Product = new Product() { ProductName = "Queso Cabrales", CategoryName = "Dairy Products" } });
            Orders.Add(new Order() { City = "Barcelona", UnitPrice = 6, Quantity = 5, Discount = 0, Freight = 1.36, Product = new Product() { ProductName = "Queso Manchego La Pastora", CategoryName = "Dairy Products" } });

            Orders.Add(new Order() { City = "London", UnitPrice = 8, Quantity = 30, Discount = 0, Freight = 22.77, Product = new Product() { ProductName = "Konbu", CategoryName = "Seafood" } });
            Orders.Add(new Order() { City = "London", UnitPrice = 26.60, Quantity = 9, Discount = 0, Freight = 22.77, Product = new Product() { ProductName = "Tofu", CategoryName = "Produce" } });
            Orders.Add(new Order() { City = "London", UnitPrice = 3.60, Quantity = 25, Discount = 5, Freight = 18.69, Product = new Product() { ProductName = "Genen Shouyu", CategoryName = "Produce" } });
            Orders.Add(new Order() { City = "London", UnitPrice = 15.60, Quantity = 2, Discount = 0, Freight = 94.34, Product = new Product() { ProductName = "Pavlova", CategoryName = "Confections" } });
            Orders.Add(new Order() { City = "London", UnitPrice = 27.20, Quantity = 56, Discount = 0, Freight = 6.54, Product = new Product() { ProductName = "Alice Mutton", CategoryName = "Produce" } });
            Orders.Add(new Order() { City = "London", UnitPrice = 28.80, Quantity = 70, Discount = 15, Freight = 1.36, Product = new Product() { ProductName = "Carnarvon Tigers", CategoryName = "Produce" } });
            #endregion SetData
        }
    }

    public class Order
    {

        [Display(Name = "City")]
        [FilterLookup("Cities", UseFlags = false, UseSelectAll = true)]
        public string City { get; set; }

        [Display(Name = "Discount (%)")]
        [FilterRange("MinDiscount", "MaxDiscount", EditorType = RangeUIEditorType.Range)]
        public double Discount { get; set; }
        [Display(Name = "Freight ($)")]
        [FilterRange("MinFreight", "MaxFreight", EditorType = RangeUIEditorType.Spin)]
        public double Freight { get; set; }
        [Display(Name = "Quantity")]
        [FilterRange("MinQuantity", "MaxQuantity", EditorType = RangeUIEditorType.Text)]
        public int Quantity { get; set; }
        [Display(Name = "UnitPrice ($)")]
        [FilterRange("MinUnitPrice", "MaxUnitPrice")]
        public double UnitPrice { get; set; }
        public Product Product { get; set; }
    }

    public class Product
    {
        public string ProductName { get; set; }

        [Display(Name = "CategoryName")]
        [FilterLookup("CategoryNames", UseFlags = false, UseSelectAll = true)]
        public string CategoryName { get; set; }
    }
}

