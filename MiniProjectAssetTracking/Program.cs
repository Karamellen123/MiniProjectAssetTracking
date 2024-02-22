// See https://aka.ms/new-console-template for more information

List<Computer> MyComputer = new List<Computer> ();
List<Phone> MyPhone = new List<Phone> ();
Console.WriteLine("AZZets");

//Debugging purposes
DateTime date1 = new DateTime(1992, 2, 10);
DateTime date2 = new DateTime(2024, 2, 20);
Computer comp1 = new Computer("Apple", "MACBOOK", "US", date1, 970);
Computer comp2 = new Computer("Windows", "Elitbook", "US", date2, 800);
Computer comp3 = new Computer("Windows", "HP", "US", date2, 840);
Computer comp4 = new Computer("Lenovo", "Yoga 730", "US", date1, 300);
MyComputer.Add(comp1);
MyComputer.Add(comp2);
MyComputer.Add(comp3);
MyComputer.Add(comp4);

DisplayLists();


void DisplayLists()
{
    //itemsList = itemsList.OrderBy(p => p.Price).ToList();
    //Sorter by 
    //MyComputer = MyComputer.OrderBy(c => c.PurchaseDate).ToList();

    DateTime currentdate = DateTime.Now;    // Get the current date,  want to modifiy this one
    DateTime expirationDate = currentdate.AddYears(3);

    for (int i = 0; i < MyComputer.Count(); i++)
    {
        // If purchase date + 3 år är mindre än dagens datum blir det rött
        DateTime temp = MyComputer[i].PurchaseDate.AddYears(3);
        if (temp <= DateTime.Now)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Your computer is too old");
        }
        else
        {
            Console.WriteLine("\nBrand:" + MyComputer[i].Brand + " \nModel: " + MyComputer[i].ModelName + " \nPurchase date:" + MyComputer[i].PurchaseDate);
        }
        Console.ResetColor();
    }
    Console.ReadKey();
}



void Lifespan()
{
    DateTime currentdate = DateTime.Now;    // Get the current date,  want to modifiy this one
    DateTime expirationDate = currentdate.AddYears(3);

    TimeSpan timeRemaining = expirationDate - currentdate;
    Console.WriteLine("Time remaining: " + timeRemaining + " \nCurrent date: " + currentdate.ToString() + " \nOld date:" + expirationDate);
}




class Computer
{
    //string computerType
    public Computer(string brand, string modelName, string office, DateTime purchaseDate, int price ) 
    {
        //ComputerType = computerType;
        Brand = brand;
        PurchaseDate = purchaseDate;
        Price = price;
        ModelName = modelName;
    }
    //public string ComputerType { get; set;}
    public string Brand { get; set;}
    public string ModelName { get; set; }

    public string Office { get; set;}

    public DateTime PurchaseDate { get; set;}
    public int Price { get; set;}

}

class Phone
{
    public Phone(string phoneType, DateTime purchaseDate, int price, string modelName)
    {
        PhoneType = phoneType;
        PurchaseDate = purchaseDate;
        Price = price;
        ModelName = modelName;
    }
    public string PhoneType { get; set; }
    public DateTime PurchaseDate { get; set; }
    public int Price { get; set;}
    public string ModelName { get; set;}

}