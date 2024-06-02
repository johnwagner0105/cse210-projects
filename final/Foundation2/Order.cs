public class Order
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
    public double CalculateTotalCost()
    {
        double cost = 0;
        foreach (Product prod in _products)
        {
            cost += prod.CalculateCost();
        }
        if (_customer.IsCustomerInUsa())
        {
            return cost += 5;
        }
        else
        {
            return cost += 35;
        }
    }
    public string DisplayPackingLabel()
    {
        string products = "";
        foreach (Product prod in _products)
        {
            products += $"{prod.GetId()} - {prod.GetName()}\n";
        }
        return $"Packing Label\n========================\n{products}";
    }
    public string DisplayShippingLabel()
    {
        string customers = $"{_customer.GetName()}\n{_customer.GetAddress().DisplayAddress()}";

        return $"Shipping Label\n========================\n{customers}\n";
    }
}