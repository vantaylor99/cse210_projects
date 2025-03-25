public class Product
{
    private string _productName;
    private string _productID;
    private double _productPrice;
    private int _productQuantity;

    public Product(string productname, string productID, double productPrice, int productQuantity)
    {
        _productName = productname;
        _productID = productID;
        _productPrice = productPrice;
        _productQuantity = productQuantity;
    }

    public string GetProductID()
    {
        return _productID;
    }

    public string GetProductName()
    {
        return _productName;
    }

    public int GetQuantity()
    {
        return _productQuantity;
    }

    public double GetPrice()
    {
        return _productPrice;
    }

    public double GetTotalCost()
    {
        return _productPrice * _productQuantity;
    }

}