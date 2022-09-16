Imports System.Linq
Imports System.ComponentModel.DataAnnotations
Imports DevExpress.Utils.Filtering
Imports System.ComponentModel

Namespace WpfApplication27

    Public Class ViewModel

        Private _Cities As String(), _CategoryNames As String(), _MinUnitPrice As Double, _MaxUnitPrice As Double, _MinDiscount As Double, _MaxDiscount As Double, _MinFreight As Double, _MaxFreight As Double, _MinQuantity As Integer, _MaxQuantity As Integer

        Public Property Orders As BindingList(Of Order)

        Public Sub New()
            Orders = New BindingList(Of Order)()
            GetOrders()
            CategoryNames = New String() {"Beverages", "Condiments", "Confections", "Dairy Products", "Grains / Cereals", "Meat / Poultry", "Produce", "Seafood"}
            Cities = New String() {"Aachen", "Barcelona", "London"}
            MaxUnitPrice = Orders.Max(Function(m) m.UnitPrice)
            MinUnitPrice = Orders.Min(Function(m) m.UnitPrice)
            MaxDiscount = Orders.Max(Function(m) m.Discount)
            MinDiscount = Orders.Min(Function(m) m.Discount)
            MinFreight = Orders.Min(Function(m) m.Freight)
            MaxFreight = Orders.Max(Function(m) m.Freight)
            MinQuantity = Orders.Min(Function(m) m.Quantity)
            MaxQuantity = Orders.Max(Function(m) m.Quantity)
        End Sub

        Public Property Cities As String()
            Get
                Return _Cities
            End Get

            Private Set(ByVal value As String())
                _Cities = value
            End Set
        End Property

        Public Property CategoryNames As String()
            Get
                Return _CategoryNames
            End Get

            Private Set(ByVal value As String())
                _CategoryNames = value
            End Set
        End Property

        Public Property MinUnitPrice As Double
            Get
                Return _MinUnitPrice
            End Get

            Private Set(ByVal value As Double)
                _MinUnitPrice = value
            End Set
        End Property

        Public Property MaxUnitPrice As Double
            Get
                Return _MaxUnitPrice
            End Get

            Private Set(ByVal value As Double)
                _MaxUnitPrice = value
            End Set
        End Property

        Public Property MinDiscount As Double
            Get
                Return _MinDiscount
            End Get

            Private Set(ByVal value As Double)
                _MinDiscount = value
            End Set
        End Property

        Public Property MaxDiscount As Double
            Get
                Return _MaxDiscount
            End Get

            Private Set(ByVal value As Double)
                _MaxDiscount = value
            End Set
        End Property

        Public Property MinFreight As Double
            Get
                Return _MinFreight
            End Get

            Private Set(ByVal value As Double)
                _MinFreight = value
            End Set
        End Property

        Public Property MaxFreight As Double
            Get
                Return _MaxFreight
            End Get

            Private Set(ByVal value As Double)
                _MaxFreight = value
            End Set
        End Property

        Public Property MinQuantity As Integer
            Get
                Return _MinQuantity
            End Get

            Private Set(ByVal value As Integer)
                _MinQuantity = value
            End Set
        End Property

        Public Property MaxQuantity As Integer
            Get
                Return _MaxQuantity
            End Get

            Private Set(ByVal value As Integer)
                _MaxQuantity = value
            End Set
        End Property

        Private Sub GetOrders()
#Region "SetData"
            Orders.Add(New Order() With {.City = "Aachen", .UnitPrice = 10, .Quantity = 20, .Discount = 0, .Freight = 30.54, .Product = New Product() With {.ProductName = "Chai", .CategoryName = "Beverages"}})
            Orders.Add(New Order() With {.City = "Aachen", .UnitPrice = 6.20, .Quantity = 12, .Discount = 0, .Freight = 30.54, .Product = New Product() With {.ProductName = "Chang", .CategoryName = "Beverages"}})
            Orders.Add(New Order() With {.City = "Aachen", .UnitPrice = 14.40, .Quantity = 12, .Discount = 2, .Freight = 30.54, .Product = New Product() With {.ProductName = "Aniseed Syrup", .CategoryName = "Condiments"}})
            Orders.Add(New Order() With {.City = "Aachen", .UnitPrice = 4.80, .Quantity = 18, .Discount = 0, .Freight = 4.45, .Product = New Product() With {.ProductName = "Chef Anton's Cajun Seasoning", .CategoryName = "Condiments"}})
            Orders.Add(New Order() With {.City = "Aachen", .UnitPrice = 21, .Quantity = 20, .Discount = 3, .Freight = 33.35, .Product = New Product() With {.ProductName = "Chef Anton's Gumbo Mix", .CategoryName = "Condiments"}})
            Orders.Add(New Order() With {.City = "Aachen", .UnitPrice = 6, .Quantity = 7, .Discount = 0, .Freight = 149.74, .Product = New Product() With {.ProductName = "Grandma's Boysenberry Spread", .CategoryName = "Condiments"}})
            Orders.Add(New Order() With {.City = "Barcelona", .UnitPrice = 16.80, .Quantity = 5, .Discount = 0, .Freight = 10.14, .Product = New Product() With {.ProductName = "Uncle Bob's Organic Dried Pears", .CategoryName = "Produce"}})
            Orders.Add(New Order() With {.City = "Barcelona", .UnitPrice = 6.20, .Quantity = 45, .Discount = 0, .Freight = 10.14, .Product = New Product() With {.ProductName = "Northwoods Cranberry Sauce", .CategoryName = "Condiments"}})
            Orders.Add(New Order() With {.City = "Barcelona", .UnitPrice = 14.40, .Quantity = 5, .Discount = 6, .Freight = 18.69, .Product = New Product() With {.ProductName = "Mishi Kobe Niku", .CategoryName = "Meat/Poultry"}})
            Orders.Add(New Order() With {.City = "Barcelona", .UnitPrice = 4.80, .Quantity = 17, .Discount = 0, .Freight = 18.69, .Product = New Product() With {.ProductName = "Ikura", .CategoryName = "Seafood"}})
            Orders.Add(New Order() With {.City = "Barcelona", .UnitPrice = 21, .Quantity = 35, .Discount = 0, .Freight = 6.54, .Product = New Product() With {.ProductName = "Queso Cabrales", .CategoryName = "Dairy Products"}})
            Orders.Add(New Order() With {.City = "Barcelona", .UnitPrice = 6, .Quantity = 5, .Discount = 0, .Freight = 1.36, .Product = New Product() With {.ProductName = "Queso Manchego La Pastora", .CategoryName = "Dairy Products"}})
            Orders.Add(New Order() With {.City = "London", .UnitPrice = 8, .Quantity = 30, .Discount = 0, .Freight = 22.77, .Product = New Product() With {.ProductName = "Konbu", .CategoryName = "Seafood"}})
            Orders.Add(New Order() With {.City = "London", .UnitPrice = 26.60, .Quantity = 9, .Discount = 0, .Freight = 22.77, .Product = New Product() With {.ProductName = "Tofu", .CategoryName = "Produce"}})
            Orders.Add(New Order() With {.City = "London", .UnitPrice = 3.60, .Quantity = 25, .Discount = 5, .Freight = 18.69, .Product = New Product() With {.ProductName = "Genen Shouyu", .CategoryName = "Produce"}})
            Orders.Add(New Order() With {.City = "London", .UnitPrice = 15.60, .Quantity = 2, .Discount = 0, .Freight = 94.34, .Product = New Product() With {.ProductName = "Pavlova", .CategoryName = "Confections"}})
            Orders.Add(New Order() With {.City = "London", .UnitPrice = 27.20, .Quantity = 56, .Discount = 0, .Freight = 6.54, .Product = New Product() With {.ProductName = "Alice Mutton", .CategoryName = "Produce"}})
            Orders.Add(New Order() With {.City = "London", .UnitPrice = 28.80, .Quantity = 70, .Discount = 15, .Freight = 1.36, .Product = New Product() With {.ProductName = "Carnarvon Tigers", .CategoryName = "Produce"}})
#End Region  ' SetData
        End Sub
    End Class

    Public Class Order

        <Display(Name:="City")>
        <FilterLookup("Cities", UseFlags:=False, UseSelectAll:=True)>
        Public Property City As String

        <Display(Name:="Discount (%)")>
        <FilterRange("MinDiscount", "MaxDiscount", EditorType:=RangeUIEditorType.Range)>
        Public Property Discount As Double

        <Display(Name:="Freight ($)")>
        <FilterRange("MinFreight", "MaxFreight", EditorType:=RangeUIEditorType.Spin)>
        Public Property Freight As Double

        <Display(Name:="Quantity")>
        <FilterRange("MinQuantity", "MaxQuantity", EditorType:=RangeUIEditorType.Text)>
        Public Property Quantity As Integer

        <Display(Name:="UnitPrice ($)")>
        <FilterRange("MinUnitPrice", "MaxUnitPrice")>
        Public Property UnitPrice As Double

        Public Property Product As Product
    End Class

    Public Class Product

        Public Property ProductName As String

        <Display(Name:="CategoryName")>
        <FilterLookup("CategoryNames", UseFlags:=False, UseSelectAll:=True)>
        Public Property CategoryName As String
    End Class
End Namespace
