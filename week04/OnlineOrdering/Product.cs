using System;
using System.Reflection.Metadata.Ecma335;

class Product
{
    private string _name;
    private string _productId;
    private float _price;
    private int _quantity;

    public Product(string name, string productId, float price, int quantity)

    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    public float TotalCost()
    {
        return _price * _quantity;
    }
    public string PackingLabel()
    {
        return $"{_name} (ID: {_productId})";      
    }

}