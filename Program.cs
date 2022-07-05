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

while (!file.EndOfStream)
{
    string singleAddress = file.ReadLine();
    Console.WriteLine(singleAddress);

    string[] data = singleAddress.Split(",");

    string name = data[0];
    string surname = data[1];
    string address = data[2];
    string street = data[3];
    string city = data[4];
    string province = data[5];
    string zipString = data[6];

    int zip = Int32.Parse(zipString);

    Address address1 = new Address(name, surname, address, city, province, zip);
    addressList.Add(address1);
}

file.Close();