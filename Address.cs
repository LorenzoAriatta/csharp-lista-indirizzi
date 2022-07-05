using System;

public class Address
{
	public string name = "";
	public string surname = "";
	public string street = "";
	public string city = "";
	public string province = "";
	public string zip;
	public Address(string name, string surname, string street, string city, string province, string zip)
	{
		this.name = name;
		this.surname = surname;
		this.street = street;
		this.city = city;
		this.province = province;
		this.zip = zip;
	}

	public void Stamp()
    {
        Console.WriteLine($"Name: {name}\nSurname: {surname}\nStreet: {street}\nCity: {city}\nProvince: {province}\nZip: {zip}");
    }
}
