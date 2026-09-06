using System;

public class Customer

{
    private string _name;
    private Address _address;

    // Constructor
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    // Getters and setters
    public string GetName()
    {
        return _name;
    }

    public Address GetAddress()
    {
        return _address;
    }

    // Check whether the customer lives in the USA
    public bool LivesInUSA()
    {
        return _address.IsInUSA();
    }

}