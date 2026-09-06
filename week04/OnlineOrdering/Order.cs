using System;
using System.Collections.Generic;

public class Order
{
    // A list of products
    private List<Product> _products;
    private Customer _customer;

    // Constructor
    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    // Add a product to the order
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    // Calculate total cost of the order
    public double GetTotalCost()
    {
        double total = 0;

        foreach (Product product in _products)
        {
            total += product.GetTotalCost();
        }

        // Add shipping cost
        if (_customer.LivesInUSA())
        {
            total += 5;
        }
        else
        {
            total += 35;
        }

        return total;
    }

    // Create pacing label
    public string GetPackingLabel()
    {
        string label = "PACKING LABEL\n";

        foreach (Product product in _products)
        {
            label += $"{product.GetName()} - {product.GetProductId()}\n";
        }

        return label;
    }

    // Create shipping label
    public string GetShippingLabel()
    {
        string label = "SHIPPING LABEL\n";
        label += $"{_customer.GetName()}\n";
        label += _customer.GetAddress().GetFullAddress();

        return label;
    }
}