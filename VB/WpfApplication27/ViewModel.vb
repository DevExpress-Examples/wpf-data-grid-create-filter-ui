Imports DevExpress.Mvvm
Imports System
Imports System.Collections.Generic
Imports System.Collections.ObjectModel
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.ComponentModel.DataAnnotations
Imports DevExpress.Utils.Filtering
Imports System.ComponentModel
Imports System.Runtime.CompilerServices

Namespace WpfApplication27
    Public Class ViewModel
        Public Property Orders() As BindingList(Of Order)
        Public Sub New()
            Orders = New BindingList(Of Order)()
            GetOrders()
            CategoryNames = New String() { "Beverages", "Condiments", "Confections", "Dairy Products", "Grains / Cereals", "Meat / Poultry", "Produce", "Seafood" }
            Cities = New String() { "Aachen", "Barcelona", "London" }
            MaxUnitPrice = Orders.Max(Function(m) m.UnitPrice)
            MinUnitPrice = Orders.Min(Function(m) m.UnitPrice)
            MaxDiscount = Orders.Max(Function(m) m.Discount)
            MinDiscount = Orders.Min(Function(m) m.Discount)
            MinFreight = Orders.Min(Function(m) m.Freight)
            MaxFreight = Orders.Max(Function(m) m.Freight)
            MinQuantity = Orders.Min(Function(m) m.Quantity)
            MaxQuantity = Orders.Max(Function(m) m.Quantity)
        End Sub
        Private privateCities As String()
        Public Property Cities() As String()
            Get
                Return privateCities
            End Get
            Private Set(ByVal value As String())
                privateCities = value
            End Set
        End Property
        Private privateCategoryNames As String()
        Public Property CategoryNames() As String()
            Get
                Return privateCategoryNames
            End Get
            Private Set(ByVal value As String())
                privateCategoryNames = value
            End Set
        End Property
        Private privateMinUnitPrice As Double
        Public Property MinUnitPrice() As Double
            Get
                Return privateMinUnitPrice
            End Get
            Private Set(ByVal value As Double)
                privateMinUnitPrice = value
            End Set
        End Property
        Private privateMaxUnitPrice As Double
        Public Property MaxUnitPrice() As Double
            Get
                Return privateMaxUnitPrice
            End Get
            Private Set(ByVal value As Double)
                privateMaxUnitPrice = value
            End Set
        End Property
        Private privateMinDiscount As Double
        Public Property MinDiscount() As Double
            Get
                Return privateMinDiscount
            End Get
            Private Set(ByVal value As Double)
                privateMinDiscount = value
            End Set
        End Property
        Private privateMaxDiscount As Double
        Public Property MaxDiscount() As Double
            Get
                Return privateMaxDiscount
            End Get
            Private Set(ByVal value As Double)
                privateMaxDiscount = value
            End Set
        End Property
        Private privateMinFreight As Double
        Public Property MinFreight() As Double
            Get
                Return privateMinFreight
            End Get
            Private Set(ByVal value As Double)
                privateMinFreight = value
            End Set
        End Property
        Private privateMaxFreight As Double
        Public Property MaxFreight() As Double
            Get
                Return privateMaxFreight
            End Get
            Private Set(ByVal value As Double)
                privateMaxFreight = value
            End Set
        End Property
        Private privateMinQuantity As Integer
        Public Property MinQuantity() As Integer
            Get
                Return privateMinQuantity
            End Get
            Private Set(ByVal value As Integer)
                privateMinQuantity = value
            End Set
        End Property
        Private privateMaxQuantity As Integer
        Public Property MaxQuantity() As Integer
            Get
                Return privateMaxQuantity
            End Get
            Private Set(ByVal value As Integer)
                privateMaxQuantity = value
            End Set
        End Property

        Private Sub GetOrders()
'            #Region "SetData"
            Orders.Add(New Order() With { _
                .City = "Aachen", _
                .UnitPrice = 10, _
                .Quantity = 20, _
                .Discount = 0, _
                .Freight = 30.54, _
                .Product = New Product() With { _
                    .ProductName = "Chai", _
                    .CategoryName = "Beverages" _
                } _
            })
            Orders.Add(New Order() With { _
                .City = "Aachen", _
                .UnitPrice = 6.20, _
                .Quantity = 12, _
                .Discount = 0, _
                .Freight = 30.54, _
                .Product = New Product() With { _
                    .ProductName = "Chang", _
                    .CategoryName = "Beverages" _
                } _
            })
            Orders.Add(New Order() With { _
                .City = "Aachen", _
                .UnitPrice = 14.40, _
                .Quantity = 12, _
                .Discount = 2, _
                .Freight = 30.54, _
                .Product = New Product() With { _
                    .ProductName = "Aniseed Syrup", _
                    .CategoryName = "Condiments" _
                } _
            })
            Orders.Add(New Order() With { _
                .City = "Aachen", _
                .UnitPrice = 4.80, _
                .Quantity = 18, _
                .Discount = 0, _
                .Freight = 4.45, _
                .Product = New Product() With { _
                    .ProductName = "Chef Anton's Cajun Seasoning", _
                    .CategoryName = "Condiments" _
                } _
            })
            Orders.Add(New Order() With { _
                .City = "Aachen", _
                .UnitPrice = 21, _
                .Quantity = 20, _
                .Discount = 3, _
                .Freight = 33.35, _
                .Product = New Product() With { _
                    .ProductName = "Chef Anton's Gumbo Mix", _
                    .CategoryName = "Condiments" _
                } _
            })
            Orders.Add(New Order() With { _
                .City = "Aachen", _
                .UnitPrice = 6, _
                .Quantity = 7, _
                .Discount = 0, _
                .Freight = 149.74, _
                .Product = New Product() With { _
                    .ProductName = "Grandma's Boysenberry Spread", _
                    .CategoryName = "Condiments" _
                } _
            })

            Orders.Add(New Order() With { _
                .City = "Barcelona", _
                .UnitPrice = 16.80, _
                .Quantity = 5, _
                .Discount = 0, _
                .Freight = 10.14, _
                .Product = New Product() With { _
                    .ProductName = "Uncle Bob's Organic Dried Pears", _
                    .CategoryName = "Produce" _
                } _
            })
            Orders.Add(New Order() With { _
                .City = "Barcelona", _
                .UnitPrice = 6.20, _
                .Quantity = 45, _
                .Discount = 0, _
                .Freight = 10.14, _
                .Product = New Product() With { _
                    .ProductName = "Northwoods Cranberry Sauce", _
                    .CategoryName = "Condiments" _
                } _
            })
            Orders.Add(New Order() With { _
                .City = "Barcelona", _
                .UnitPrice = 14.40, _
                .Quantity = 5, _
                .Discount = 6, _
                .Freight = 18.69, _
                .Product = New Product() With { _
                    .ProductName = "Mishi Kobe Niku", _
                    .CategoryName = "Meat/Poultry" _
                } _
            })
            Orders.Add(New Order() With { _
                .City = "Barcelona", _
                .UnitPrice = 4.80, _
                .Quantity = 17, _
                .Discount = 0, _
                .Freight = 18.69, _
                .Product = New Product() With { _
                    .ProductName = "Ikura", _
                    .CategoryName = "Seafood" _
                } _
            })
            Orders.Add(New Order() With { _
                .City = "Barcelona", _
                .UnitPrice = 21, _
                .Quantity = 35, _
                .Discount = 0, _
                .Freight = 6.54, _
                .Product = New Product() With { _
                    .ProductName = "Queso Cabrales", _
                    .CategoryName = "Dairy Products" _
                } _
            })
            Orders.Add(New Order() With { _
                .City = "Barcelona", _
                .UnitPrice = 6, _
                .Quantity = 5, _
                .Discount = 0, _
                .Freight = 1.36, _
                .Product = New Product() With { _
                    .ProductName = "Queso Manchego La Pastora", _
                    .CategoryName = "Dairy Products" _
                } _
            })

            Orders.Add(New Order() With { _
                .City = "London", _
                .UnitPrice = 8, _
                .Quantity = 30, _
                .Discount = 0, _
                .Freight = 22.77, _
                .Product = New Product() With { _
                    .ProductName = "Konbu", _
                    .CategoryName = "Seafood" _
                } _
            })
            Orders.Add(New Order() With { _
                .City = "London", _
                .UnitPrice = 26.60, _
                .Quantity = 9, _
                .Discount = 0, _
                .Freight = 22.77, _
                .Product = New Product() With { _
                    .ProductName = "Tofu", _
                    .CategoryName = "Produce" _
                } _
            })
            Orders.Add(New Order() With { _
                .City = "London", _
                .UnitPrice = 3.60, _
                .Quantity = 25, _
                .Discount = 5, _
                .Freight = 18.69, _
                .Product = New Product() With { _
                    .ProductName = "Genen Shouyu", _
                    .CategoryName = "Produce" _
                } _
            })
            Orders.Add(New Order() With { _
                .City = "London", _
                .UnitPrice = 15.60, _
                .Quantity = 2, _
                .Discount = 0, _
                .Freight = 94.34, _
                .Product = New Product() With { _
                    .ProductName = "Pavlova", _
                    .CategoryName = "Confections" _
                } _
            })
            Orders.Add(New Order() With { _
                .City = "London", _
                .UnitPrice = 27.20, _
                .Quantity = 56, _
                .Discount = 0, _
                .Freight = 6.54, _
                .Product = New Product() With { _
                    .ProductName = "Alice Mutton", _
                    .CategoryName = "Produce" _
                } _
            })
            Orders.Add(New Order() With { _
                .City = "London", _
                .UnitPrice = 28.80, _
                .Quantity = 70, _
                .Discount = 15, _
                .Freight = 1.36, _
                .Product = New Product() With { _
                    .ProductName = "Carnarvon Tigers", _
                    .CategoryName = "Produce" _
                } _
            })
'            #End Region ' SetData
        End Sub
    End Class

    Public Class Order

        <Display(Name := "City"), FilterLookup("Cities", UseFlags := False, UseSelectAll := True)> _
        Public Property City() As String

        <Display(Name := "Discount (%)"), FilterRange("MinDiscount", "MaxDiscount", EditorType := RangeUIEditorType.Range)> _
        Public Property Discount() As Double
        <Display(Name := "Freight ($)"), FilterRange("MinFreight", "MaxFreight", EditorType := RangeUIEditorType.Spin)> _
        Public Property Freight() As Double
        <Display(Name := "Quantity"), FilterRange("MinQuantity", "MaxQuantity", EditorType := RangeUIEditorType.Text)> _
        Public Property Quantity() As Integer
        <Display(Name := "UnitPrice ($)"), FilterRange("MinUnitPrice", "MaxUnitPrice")> _
        Public Property UnitPrice() As Double
        Public Property Product() As Product
    End Class

    Public Class Product
        Public Property ProductName() As String

        <Display(Name := "CategoryName"), FilterLookup("CategoryNames", UseFlags := False, UseSelectAll := True)> _
        Public Property CategoryName() As String
    End Class
End Namespace

