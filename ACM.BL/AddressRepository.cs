using System.Diagnostics.Metrics;

namespace ACM.BL;

public class AddressRepository
{
    // Retrieve one address
    public Address Retrieve(int addressId)
    {
        // Create the instance of the Address class and pass in the requested Id
        Address address = new Address(addressId);

        // Temporary hard coded values to return a populated address
        if (addressId == 1)
        {
            address.AddressType = 1;
            address.StreetLine1 = "2 Seaton Close";
            address.StreetLine2 = "Lightwood";
            address.City = "Stoke-on-Trent";
            address.County = "Staffordshire";
            address.Country = "United Kingdom";
            address.PostCode = "ST3 7UP";
        }
        return address;
    }

    public IEnumerable<Address> RetrieveByCustomerId(int customerId)
    {
        // Temporary hard-coded values to return a set of addresses for a customer
        var addressList = new List<Address>();

        Address address = new Address(1);
        {
            address.AddressType = 1;
            address.StreetLine1 = "2 Seaton Close";
            address.StreetLine2 = "Lightwood";
            address.City = "Stoke-on-Trent";
            address.County = "Staffordshire";
            address.Country = "United Kingdom";
            address.PostCode = "ST3 7UP";
        }
        addressList.Add(address);

        address = new Address(2);
        {
            address.StreetLine1 = "Cambridge Road";
            address.StreetLine2 = "";
            address.City = "North Carlton";
            address.County = "Lincolnshire";
            address.Country = "United Kingdom";
            address.PostCode = "LN1 9BG";
        }
        addressList.Add(address);

        return addressList;
    }

    // Saves the current address
    public bool Save(Address address)
    {
        return true;
    }
}