Imports DevExpress.Mvvm
Imports System.Collections.ObjectModel

Namespace GridControlFilterUI

    Public Class ViewModel
        Inherits ViewModelBase

        Public Property Orders As ObservableCollection(Of Order)

        Public Sub New()
            Orders = OrdersModel.GetOrders()
        End Sub
    End Class

    Public Class Order

        Public Property City As String

        Public Property Discount As Double

        Public Property Freight As Double

        Public Property Quantity As Integer

        Public Property UnitPrice As Double

        Public Property Product As Product
    End Class

    Public Class Product

        Public Property ProductName As String

        Public Property CategoryName As String
    End Class

    Public Class OrdersModel

        Public Shared Function GetOrders() As ObservableCollection(Of Order)
            Dim orders As ObservableCollection(Of Order) = New ObservableCollection(Of Order)()
            orders.Add(New Order() With {.City = "Aachen", .UnitPrice = 10, .Quantity = 20, .Discount = 0, .Freight = 30.54, .Product = New Product() With {.ProductName = "Chai", .CategoryName = "Beverages"}})
            orders.Add(New Order() With {.City = "Aachen", .UnitPrice = 6.20, .Quantity = 12, .Discount = 0, .Freight = 30.54, .Product = New Product() With {.ProductName = "Chang", .CategoryName = "Beverages"}})
            orders.Add(New Order() With {.City = "Aachen", .UnitPrice = 14.40, .Quantity = 12, .Discount = 2, .Freight = 30.54, .Product = New Product() With {.ProductName = "Aniseed Syrup", .CategoryName = "Condiments"}})
            orders.Add(New Order() With {.City = "Aachen", .UnitPrice = 4.80, .Quantity = 18, .Discount = 0, .Freight = 4.45, .Product = New Product() With {.ProductName = "Chef Anton's Cajun Seasoning", .CategoryName = "Condiments"}})
            orders.Add(New Order() With {.City = "Aachen", .UnitPrice = 21, .Quantity = 20, .Discount = 3, .Freight = 33.35, .Product = New Product() With {.ProductName = "Chef Anton's Gumbo Mix", .CategoryName = "Condiments"}})
            orders.Add(New Order() With {.City = "Aachen", .UnitPrice = 6, .Quantity = 7, .Discount = 0, .Freight = 149.74, .Product = New Product() With {.ProductName = "Grandma's Boysenberry Spread", .CategoryName = "Condiments"}})
            orders.Add(New Order() With {.City = "Barcelona", .UnitPrice = 16.80, .Quantity = 5, .Discount = 0, .Freight = 10.14, .Product = New Product() With {.ProductName = "Uncle Bob's Organic Dried Pears", .CategoryName = "Produce"}})
            orders.Add(New Order() With {.City = "Barcelona", .UnitPrice = 6.20, .Quantity = 45, .Discount = 0, .Freight = 10.14, .Product = New Product() With {.ProductName = "Northwoods Cranberry Sauce", .CategoryName = "Condiments"}})
            orders.Add(New Order() With {.City = "Barcelona", .UnitPrice = 14.40, .Quantity = 5, .Discount = 6, .Freight = 18.69, .Product = New Product() With {.ProductName = "Mishi Kobe Niku", .CategoryName = "Meat/Poultry"}})
            orders.Add(New Order() With {.City = "Barcelona", .UnitPrice = 4.80, .Quantity = 17, .Discount = 0, .Freight = 18.69, .Product = New Product() With {.ProductName = "Ikura", .CategoryName = "Seafood"}})
            orders.Add(New Order() With {.City = "Barcelona", .UnitPrice = 21, .Quantity = 35, .Discount = 0, .Freight = 6.54, .Product = New Product() With {.ProductName = "Queso Cabrales", .CategoryName = "Dairy Products"}})
            orders.Add(New Order() With {.City = "Barcelona", .UnitPrice = 6, .Quantity = 5, .Discount = 0, .Freight = 1.36, .Product = New Product() With {.ProductName = "Queso Manchego La Pastora", .CategoryName = "Dairy Products"}})
            orders.Add(New Order() With {.City = "London", .UnitPrice = 8, .Quantity = 30, .Discount = 0, .Freight = 22.77, .Product = New Product() With {.ProductName = "Konbu", .CategoryName = "Seafood"}})
            orders.Add(New Order() With {.City = "London", .UnitPrice = 26.60, .Quantity = 9, .Discount = 0, .Freight = 22.77, .Product = New Product() With {.ProductName = "Tofu", .CategoryName = "Produce"}})
            orders.Add(New Order() With {.City = "London", .UnitPrice = 3.60, .Quantity = 25, .Discount = 5, .Freight = 18.69, .Product = New Product() With {.ProductName = "Genen Shouyu", .CategoryName = "Produce"}})
            orders.Add(New Order() With {.City = "London", .UnitPrice = 15.60, .Quantity = 2, .Discount = 0, .Freight = 94.34, .Product = New Product() With {.ProductName = "Pavlova", .CategoryName = "Confections"}})
            orders.Add(New Order() With {.City = "London", .UnitPrice = 27.20, .Quantity = 56, .Discount = 0, .Freight = 6.54, .Product = New Product() With {.ProductName = "Alice Mutton", .CategoryName = "Produce"}})
            orders.Add(New Order() With {.City = "London", .UnitPrice = 28.80, .Quantity = 70, .Discount = 15, .Freight = 1.36, .Product = New Product() With {.ProductName = "Carnarvon Tigers", .CategoryName = "Produce"}})
            Return orders
        End Function
    End Class
End Namespace
