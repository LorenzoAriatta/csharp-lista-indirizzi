// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
/*
In questo esercizio dovrete leggere un file CSV, non tanto differente da quanto visto nel live-coding in classe,e 
salvare tutti gli indirizzi contenuti al sul interno all’interno di una lista di oggetti istanziati a partire dalla classe Indirizzo.
Attenzione: gli ultimi 3 indirizzi presentano dei possibili “casi particolari” che possono accadere a questo genere di file: vi chiedo di pensarci e
di gestire come meglio crediate queste casistiche.
*/

StreamReader file = File.OpenText("C:/.NET_projects/csharp/csharp-lista-indirizzi/addresses.csv");

string firstLine = file.ReadLine();

List<Address> addressList = new List<Address>();
List<string> corruptedString = new List<string>();

while (!file.EndOfStream)
{
    string singleAddress = file.ReadLine();
    //Console.WriteLine(singleAddress);

    string[] data = singleAddress.Split(",");
    try
    {

        string name = data[0];
        string surname = data[1];
        string street = data[2];
        string city = data[3];
        string province = data[4];
        string zipString = data[5];

        try
        {
            int zip = int.Parse(data[5]);
        }
        catch (FormatException e)
        {
            zipString = "---";
        }

        Address address = new Address(name, surname, street, city, province, zipString);
        addressList.Add(address);
    }
    catch (IndexOutOfRangeException e)
    {
        corruptedString.Add(singleAddress);
    }
}

foreach(Address address in addressList)
{
    Console.WriteLine();
    Console.WriteLine(address.Stamp());
    Console.WriteLine();
    
}

foreach(string corrupted in corruptedString)
{
    Console.WriteLine("---------- CORRUPTED List ----------");
    Console.WriteLine();
    Console.WriteLine(corrupted);
    Console.WriteLine();
}

file.Close();

StreamWriter formattedFile = File.CreateText("C:/.NET_projects/csharp/csharp-lista-indirizzi/fomrmatted_addresses.csv");

foreach(Address address in addressList)
{
    formattedFile.WriteLine(address.Stamp());
}

formattedFile.Close();