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

	public string Stamp()
    {
		string description = $"------Address List------\n" +
					$"Name: {name}\n" +
					$"Surname: {surname}\n" +
					$"Street: {street}\n" +
					$"City: {city}\n" +
					$"Province: {province}\n" +
					$"Zip: {zip}\n" +
			"------------------------";

		return description;
	}
}
