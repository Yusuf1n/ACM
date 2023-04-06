namespace ACM.BL;

public class Address
{
    public Address()
    {
        
    }

    public Address(int addressId)
    {
        AddressId = addressId;
    }

    public int AddressId { get; set; }

    public int AddressType { get; set; }

    public string StreetLine1 { get; set; }

    public string StreetLine2 { get; set; }

    public string County { get; set; }

    public string PostCode { get; set; }

    public string City { get; set; }

    public string Country { get; set; }

    public bool Validate()
    {
        var isValid = true;

        if (PostCode == null) isValid = false;

        return isValid;
    }
}