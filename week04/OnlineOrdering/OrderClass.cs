using System.Reflection.Emit;

public class Order
{
    private List<Product> _listOfProducts = new List<Product>();



    private Customer _customer;

    public Order (Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _listOfProducts.Add(product);
    }

    public double GetTotalCost()
    {
        double sum = 0;

        foreach (Product p in _listOfProducts)
        {
            sum += p.GetTotalCost();
        }

        if (_customer.LivesInUSA() == true)
        {
            sum += 5;
        }
        else
        {
            sum += 35;
        }
        
        return sum;
    }

    public string GetPackingLable()
    {
        string lable = "Packing Label: \n";

        foreach (Product p in _listOfProducts)
        {
            lable += $"-Item: ({p.GetProductName()}) Product ID: ({p.GetProductID()}) \nQuantity: ({p.GetQuantity()}) Price Per Unit: (${p.GetPrice():F2}) \n";
        }

        return lable;

    }

    public string GetShippingLable()
    {
        return $"Shipping Lable: \n{_customer.GetName()}\n{_customer.getFormattedAddress()}";
    }

}