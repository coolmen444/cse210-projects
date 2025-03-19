public class Order
{
    private List<Product> _productList = new List<Product>();
    Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer; 
    }

    public double CalculateTotalCost()
    {
        double total_cost = 0;
        foreach (Product product in _productList)
        {
            total_cost += product.CalculateTotalCost();
        }

        if (_customer.IsInUS())
        {
            total_cost += 5;
        }
        else 
        {
            total_cost += 35;
        }
        return Math.Round(total_cost, 2);
    }

    public string GetPackingLabel()
    {
        string packingLabel = "";

        foreach (Product product in _productList)
        {
            packingLabel += $"{product.GetName()} {product.GetProductId()}\n";
        }

        return packingLabel;
    }

    public string GetShippingLabel()
    {
        return $"{_customer.GetName()}\n{_customer.GetAddress()}";
    }

     public void AddProduct(Product product)
    {
        _productList.Add(product);
    }
}