using DevExpress.Mvvm;
using System;
using System.Collections.ObjectModel;
using System.Windows;

namespace WpfApplication1 {
    public partial class Window1 : Window {
        public Window1() {
            InitializeComponent();
        }
    }
    public class ViewModel : ViewModelBase {
        public ViewModel() {
            Source = ProductsDataModel.GetProducts();
        }
        public ObservableCollection<Product> Source { get; }
    }
    public class ProductsDataModel {
        public static ObservableCollection<Product> GetProducts() {
            ObservableCollection<Product> products = new ObservableCollection<Product> {
                new Product() {
                    ProductName = "Chang", Country = "UK", City = "Cowes",
                    Quantity = 10, OrderDate = new DateTime(2021, 10, 23)
                },
                new Product() {
                    ProductName = "Gnocchi di nonna Alice", Country = "Italy", City = "Reggio Emilia",
                    Quantity = 16, OrderDate = new DateTime(2021, 10, 22)
                },
                new Product() {
                    ProductName = "Ravioli Angelo", Country = "Brazil", City = "Rio de Janeiro", 
                    Quantity = 12, OrderDate = new DateTime(2021, 10, 21)
                },
                new Product() {
                    ProductName = "Tarte au sucre", Country = "Germany", City = "Leipzig",
                    Quantity = 50, OrderDate = new DateTime(2021, 10, 15)
                },
                new Product() {
                    ProductName = "Steeleye Stout", Country = "USA", City = "Denver",
                    Quantity = 20, OrderDate = new DateTime(2021, 10, 8)
                },
                new Product() {
                    ProductName = "Pavlova", Country = "Austria", City = "Graz",
                    Quantity = 52, OrderDate = new DateTime(2021, 10, 1)
                },
                new Product() {
                    ProductName = "Longlife Tofu", Country = "USA", City = "Boise",
                    Quantity = 120, OrderDate = new DateTime(2021, 9, 17)
                },
                new Product() {
                    ProductName = "Alice Mutton", Country = "Mexico", City = "México D.F.",
                    Quantity = 15, OrderDate = new DateTime(2021, 9, 25)
                }
            };
            return products;
        }
    }
}
