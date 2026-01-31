using System;
using System.Runtime.InteropServices.Marshalling;

class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)

    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)

    {
        _products.Add(product);
    }

    public float TotalCost()

    {
        float total = 0;

        foreach (var product in _products)
        {
            total += product.TotalCost();
        }

        if (_customer.InUSA())
        {
            total += 5;
        }
        else
        {
            total += 35;
        }

        return total;
    }

    // why is this line 51 having a issue.   its looking at products class line 24..  
    public string GetPackingLabel()
    {
        string label = "Packing Label:";

        foreach (var product in _products)
        {
            label += product.PackingLabel();
            // label+= "---------------------------------------";
        }

        return label;
    }

    public string GetShippingLabel()
    {
        // Console.WriteLine("---------------------------------------");
        return $"Shipping Label: {_customer.GetName()}, \n {_customer.GetAddress()}";
    }

}