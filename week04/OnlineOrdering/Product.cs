using System.Runtime.InteropServices;

public class Product
{
    private string _name;
    private string _code;
    private float _price;
    private int _quantity;

    public Product(string name, string code, float price, int quantity)
    {
        _name = name;
        _code = code;
        _price = price;
        _quantity = quantity;
    }
    public float CalcualteTotalCost()
    {
        return (float)_price * (float)_quantity;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetCode()
    {
        return _code;
    }
}