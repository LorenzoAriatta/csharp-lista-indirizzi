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
    try
    {
        string singleAddress = file.ReadLine();
        //Console.WriteLine(singleAddress);

        string[] data = singleAddress.Split(",");

        string name = data[0];
        string surname = data[1];
        string street = data[2];
        string city = data[3];
        string province = data[4];
        string zipString = data[5];

        //int zip = Int32.Parse(zipString);

        Address address = new Address(name, surname, street, city, province, zipString);
        addressList.Add(address);
    }
    catch (IndexOutOfRangeException e)
    {
        string corrupted = file.ReadLine();
        corruptedString.Add(corrupted);
    }
}

foreach(Address address in addressList)
{
    Console.WriteLine("---------- Address List ----------");
    Console.WriteLine();
    address.Stamp();
    Console.WriteLine();
    
}

file.Close();