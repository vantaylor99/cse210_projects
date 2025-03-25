public class Customer
{
    private string _fullAddress;
    private Address _address;
    private string _name;


    public void SetAddress(string address)
    {
        _fullAddress = address;

    }

    public string GetName()
    {
        return _name;
    }

    public string getFormattedAddress()
    {
        return _address.getFormattedAddress();
    }

    private string[] SplitAddress(string fullAddress)
    {
        string[] parts = fullAddress.Split(",");
        string street = parts[0].Trim();

        string[] locationParts = parts[1].Trim().Split(" ");

        
        string country = locationParts[locationParts.Length - 1];
        string state = locationParts[locationParts.Length - 2];

        string city = string.Join(" ", locationParts.Take(locationParts.Length - 2));
        

        return new string[] { street, city, state, country };
    }



    public Customer(string name, string fullAddress)
    {
        _fullAddress = fullAddress;

        string[] addressParts = SplitAddress(_fullAddress);
        Address address = new Address(addressParts[0], addressParts[1], addressParts[2], addressParts[3]);

        _address = address;
        _name = name;
    }

    public bool LivesInUSA()
    {
        return _address.IsInUSA();
    }



}