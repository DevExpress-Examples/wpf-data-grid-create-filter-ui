using DevExpress.Mvvm;
using System.Collections.ObjectModel;

namespace GridControlFilterUI {
    public class ViewModel : ViewModelBase {
        public ObservableCollection<Order> Orders { get; set; }
        public ViewModel() {
            Orders = OrdersModel.GetOrders();
        }
    }

    public class Order {
        public string City { get; set; }
        public double Discount { get; set; }
        public double Freight { get; set; }
        public int Quantity { get; set; }
        public double UnitPrice { get; set; }
        public Product Product { get; set; }
    }

    public class Product {
        public string ProductName { get; set; }
        public string CategoryName { get; set; }
    }

    public class OrdersModel {
        public static ObservableCollection<Order>GetOrders() {
            ObservableCollection<Order> orders = new ObservableCollection<Order>();

            orders.Add(new Order() { City = "Aachen", UnitPrice = 10, Quantity = 20, Discount = 0, Freight = 30.54, Product = new Product() { ProductName = "Chai", CategoryName = "Beverages" } });
            orders.Add(new Order() { City = "Aachen", UnitPrice = 6.20, Quantity = 12, Discount = 0, Freight = 30.54, Product = new Product() { ProductName = "Chang", CategoryName = "Beverages" } });
            orders.Add(new Order() { City = "Aachen", UnitPrice = 14.40, Quantity = 12, Discount = 2, Freight = 30.54, Product = new Product() { ProductName = "Aniseed Syrup", CategoryName = "Condiments" } });
            orders.Add(new Order() { City = "Aachen", UnitPrice = 4.80, Quantity = 18, Discount = 0, Freight = 4.45, Product = new Product() { ProductName = "Chef Anton's Cajun Seasoning", CategoryName = "Condiments" } });
            orders.Add(new Order() { City = "Aachen", UnitPrice = 21, Quantity = 20, Discount = 3, Freight = 33.35, Product = new Product() { ProductName = "Chef Anton's Gumbo Mix", CategoryName = "Condiments" } });
            orders.Add(new Order() { City = "Aachen", UnitPrice = 6, Quantity = 7, Discount = 0, Freight = 149.74, Product = new Product() { ProductName = "Grandma's Boysenberry Spread", CategoryName = "Condiments" } });

            orders.Add(new Order() { City = "Barcelona", UnitPrice = 16.80, Quantity = 5, Discount = 0, Freight = 10.14, Product = new Product() { ProductName = "Uncle Bob's Organic Dried Pears", CategoryName = "Produce" } });
            orders.Add(new Order() { City = "Barcelona", UnitPrice = 6.20, Quantity = 45, Discount = 0, Freight = 10.14, Product = new Product() { ProductName = "Northwoods Cranberry Sauce", CategoryName = "Condiments" } });
            orders.Add(new Order() { City = "Barcelona", UnitPrice = 14.40, Quantity = 5, Discount = 6, Freight = 18.69, Product = new Product() { ProductName = "Mishi Kobe Niku", CategoryName = "Meat/Poultry" } });
            orders.Add(new Order() { City = "Barcelona", UnitPrice = 4.80, Quantity = 17, Discount = 0, Freight = 18.69, Product = new Product() { ProductName = "Ikura", CategoryName = "Seafood" } });
            orders.Add(new Order() { City = "Barcelona", UnitPrice = 21, Quantity = 35, Discount = 0, Freight = 6.54, Product = new Product() { ProductName = "Queso Cabrales", CategoryName = "Dairy Products" } });
            orders.Add(new Order() { City = "Barcelona", UnitPrice = 6, Quantity = 5, Discount = 0, Freight = 1.36, Product = new Product() { ProductName = "Queso Manchego La Pastora", CategoryName = "Dairy Products" } });

            orders.Add(new Order() { City = "London", UnitPrice = 8, Quantity = 30, Discount = 0, Freight = 22.77, Product = new Product() { ProductName = "Konbu", CategoryName = "Seafood" } });
            orders.Add(new Order() { City = "London", UnitPrice = 26.60, Quantity = 9, Discount = 0, Freight = 22.77, Product = new Product() { ProductName = "Tofu", CategoryName = "Produce" } });
            orders.Add(new Order() { City = "London", UnitPrice = 3.60, Quantity = 25, Discount = 5, Freight = 18.69, Product = new Product() { ProductName = "Genen Shouyu", CategoryName = "Produce" } });
            orders.Add(new Order() { City = "London", UnitPrice = 15.60, Quantity = 2, Discount = 0, Freight = 94.34, Product = new Product() { ProductName = "Pavlova", CategoryName = "Confections" } });
            orders.Add(new Order() { City = "London", UnitPrice = 27.20, Quantity = 56, Discount = 0, Freight = 6.54, Product = new Product() { ProductName = "Alice Mutton", CategoryName = "Produce" } });
            orders.Add(new Order() { City = "London", UnitPrice = 28.80, Quantity = 70, Discount = 15, Freight = 1.36, Product = new Product() { ProductName = "Carnarvon Tigers", CategoryName = "Produce" } });

            return orders;
        }
    }
}
