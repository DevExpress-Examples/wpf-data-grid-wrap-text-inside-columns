Imports DevExpress.Mvvm
Imports System
Imports System.Collections.ObjectModel
Imports System.Windows

Namespace WpfApplication1

    Public Partial Class Window1
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
        End Sub
    End Class

    Public Class ViewModel
        Inherits ViewModelBase

        Public Sub New()
            Source = ProductsDataModel.GetProducts()
        End Sub

        Public ReadOnly Property Source As ObservableCollection(Of Product)
    End Class

    Public Class ProductsDataModel

        Public Shared Function GetProducts() As ObservableCollection(Of Product)
            Dim products As ObservableCollection(Of Product) = New ObservableCollection(Of Product) From {New Product() With {.ProductName = "Chang", .Country = "UK", .City = "Cowes", .Quantity = 10, .OrderDate = New DateTime(2021, 10, 23)}, New Product() With {.ProductName = "Gnocchi di nonna Alice", .Country = "Italy", .City = "Reggio Emilia", .Quantity = 16, .OrderDate = New DateTime(2021, 10, 22)}, New Product() With {.ProductName = "Ravioli Angelo", .Country = "Brazil", .City = "Rio de Janeiro", .Quantity = 12, .OrderDate = New DateTime(2021, 10, 21)}, New Product() With {.ProductName = "Tarte au sucre", .Country = "Germany", .City = "Leipzig", .Quantity = 50, .OrderDate = New DateTime(2021, 10, 15)}, New Product() With {.ProductName = "Steeleye Stout", .Country = "USA", .City = "Denver", .Quantity = 20, .OrderDate = New DateTime(2021, 10, 8)}, New Product() With {.ProductName = "Pavlova", .Country = "Austria", .City = "Graz", .Quantity = 52, .OrderDate = New DateTime(2021, 10, 1)}, New Product() With {.ProductName = "Longlife Tofu", .Country = "USA", .City = "Boise", .Quantity = 120, .OrderDate = New DateTime(2021, 9, 17)}, New Product() With {.ProductName = "Alice Mutton", .Country = "Mexico", .City = "México D.F.", .Quantity = 15, .OrderDate = New DateTime(2021, 9, 25)}}
            Return products
        End Function
    End Class
End Namespace
