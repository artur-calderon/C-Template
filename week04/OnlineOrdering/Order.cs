public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;


    public void SetCustomer(Customer customer)
    {
        _customer = customer;
    }
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public float CalcualteTotalCost()
    {
        float totalCost = 0;
        foreach (Product product in _products)
        {
            if (_customer.LivesInUSA())
            {
                totalCost = product.CalcualteTotalCost() + 5;
            }

            totalCost = product.CalcualteTotalCost() + 35;
        }
        return totalCost;
    }

    public void DisplayPackingLabel()
    {
        foreach (Product product in _products)
        {
            Console.WriteLine($"{product.GetName()} ({product.GetCode()})");
        }
    }

    public void DisplayShippingLabel()
    {
        Console.WriteLine(_customer.DisplayShippingLabel());
    }
}