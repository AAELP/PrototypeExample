using System;
using System.Collections.ObjectModel;
using Microsoft.Maui.Controls;

namespace PrototypeExample
{
    public partial class MainPage : ContentPage
    {
        private ObservableCollection<Product> _products;
        private Product _originalProduct;

        public MainPage()
        {
            InitializeComponent();

            _products = new ObservableCollection<Product>();
            ProductsListView.ItemsSource = _products;

            // Crear un producto original
            _originalProduct = new Product("Laptop", 999.99);
            _products.Add(_originalProduct);
        }

        private void OnCloneProductClicked(object sender, EventArgs e)
        {
            // Clonar el producto original
            var clonedProduct = _originalProduct.Clone();
            clonedProduct.Name += " (Cloned)";
            _products.Add(clonedProduct);
        }
    }
}
