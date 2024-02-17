using System.Reflection.Metadata.Ecma335;
using System.Text;

public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;
    private double _totalCost;
    private StringBuilder sb = new StringBuilder();
    private string _packageLavel;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public double GetTotalCost()
    {
        foreach (Product product in _products)
        {
            _totalCost += product.GetCost();
        }

        if (_customer.IsInUSA())
        {
            _totalCost += 5;
        }
        else{
            _totalCost += 35;
        }

        return _totalCost;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public string GetPackingLabel()
    {
        foreach (Product product in _products)
        {
            sb.Append($"Product Name: {product.GetName()}. Product ID: {product.GetID()}.\n");
        }

        _packageLavel = sb.ToString();

        return _packageLavel;
    }

    public string GetShippingLabel()
    {
        return $"Customer Name: {_customer.GetName()}. \nAdress: {_customer.GetAddress()}";
    }
}