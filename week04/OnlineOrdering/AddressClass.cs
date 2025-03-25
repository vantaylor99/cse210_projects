public class Address
{


 private string _streetAddress; 
 private string _city;
 private string _state;
 private string _country;

    public Address(string street, string city, string state, string country)
    {
        _streetAddress = street;
        _city = city;
        _state = state;
        _country = country;
    }

    public bool IsInUSA()
    {
        if (_country == "USA")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public string GetAddress()
    {
        return getFormattedAddress();
    }

    public string getFormattedAddress()
    {
        return $"{_streetAddress}, \n{_city} {_state} {_country}";
    }



}