// See https://aka.ms/new-console-template for more information

using System.Security.Cryptography.X509Certificates;

List<Computer> MyComputer = new List<Computer> ();
List<Phone> MyPhone = new List<Phone> ();
Console.WriteLine("AZZets");

//Debugging purposes
DateTime date1 = new DateTime(1992, 2, 10);
//DateTime date3 = new DateTime(2021, 2, 23
DateTime date3 = new DateTime(2021 , 2, 24);
//DateTime date3 = new DateTime(2021 , 5, 22);

DateTime date2 = new DateTime(2024, 2, 20);

/*
DateTime Trialdate = new DateTime(2021, 2, 22);
DateTime tempo = Trialdate.AddYears(3);
tempo= tempo.AddMonths(-3);
Console.WriteLine("Tempo: " + tempo);
TimeSpan temp2 = DateTime.Today - tempo;
Console.WriteLine("Time difference: " + temp2.TotalDays);

Computer comp1 = new Computer("Apple", "MACBOOK", "US", date1, 970);
Computer comp2 = new Computer("Windows", "Elitbook", "US", date2, 800);
Computer comp3 = new Computer("Windows", "HP", "US", date3, 840);
Computer comp4 = new Computer("Lenovo", "Yoga 730", "US", date1, 300);
MyComputer.Add(comp1);
*/

Computer comp1 = new Computer("Apple", "MACBOOK", date1, 970, new Office("US", "Dollar"));
Computer comp2 = new Computer("Windows", "Elitbook", date2, 800, new Office("Japan", "Yen"));
Computer comp3 = new Computer("Windows", "HP", date3, 840, new Office("Sweden", "SEK"));
Computer comp4 = new Computer("Lenovo", "Yoga 730", date1, 300, new Office("US", "Dollar"));
MyComputer.Add(comp1);
MyComputer.Add(comp2);
MyComputer.Add(comp3);
MyComputer.Add(comp4);


Phone phone1 = new Phone("Huawei", "Huawei p9 lite", date2, 300, new Office("US", "Dollar"));
Phone phone2 = new Phone("Apple", "Iphone 9", date3, 1000, new Office("US", "Dollar"));
Phone phone3 = new Phone("Samsung", "Samsung galaxy 4", date1, 200, new Office("US", "Dollar"));
Phone phone4 = new Phone("Google", "Google Pixle pro 8", date3, 150, new Office("Sweden", "SEK")); ;
Phone phone5 = new Phone("Apple", "Iphone 2", date2, 500, new Office("US", "Dollar"));
MyPhone.Add(phone1);
MyPhone.Add(phone2);
MyPhone.Add(phone3);
MyPhone.Add(phone4);
MyPhone.Add(phone5);

DisplayLists();


void DisplayLists()
{
    //Sorter by purchase date
    MyComputer = MyComputer.OrderBy(c => c.Office.OfficeName).ThenBy(c => c.PurchaseDate).ToList();

    for (int i = 0; i < MyComputer.Count(); i++)
    {
        DateTime temp = MyComputer[i].PurchaseDate.AddYears(3);
        TimeSpan difference = temp - DateTime.Today;

        DateTime toOld = MyComputer[i].PurchaseDate.AddYears(3);
        
        if (toOld <= DateTime.Now || difference.TotalDays <= 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nBrand:" + MyComputer[i].Brand + " \nModel: " + MyComputer[i].ModelName + " \nPurchase date:" + MyComputer[i].PurchaseDate + "\nOffie: " + MyComputer[i].Office.OfficeName);
            Console.WriteLine("Days left: " + Math.Floor(difference.TotalDays));
        }
        else if (difference.TotalDays >= 0 && difference.TotalDays <= 90)
        {
            
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nBrand:" + MyComputer[i].Brand + " \nModel: " + MyComputer[i].ModelName + " \nPurchase date:" + MyComputer[i].PurchaseDate + "\nOffie: " + MyComputer[i].Office.OfficeName);
            Console.WriteLine("Days left: " + Math.Floor(difference.TotalDays));
        }
        else
        {
            Console.WriteLine("\nBrand:" + MyComputer[i].Brand + " \nModel: " + MyComputer[i].ModelName + " \nPurchase date:" + MyComputer[i].PurchaseDate + "\nOffie: " + MyComputer[i].Office.OfficeName);
            Console.WriteLine("Days left: " + Math.Floor(difference.TotalDays));
        }
        Console.ResetColor();
    }

    MyPhone = MyPhone.OrderBy(p => p.Office.OfficeName).ThenBy(p => p.PurchaseDate).ToList();
    Console.WriteLine("_________________________________________________________________");
    for (int i = 0; i < MyPhone.Count(); i++)
    {
        DateTime temp = MyPhone[i].PurchaseDate.AddYears(3);
        TimeSpan difference = temp - DateTime.Today;

        DateTime toOld = MyPhone[i].PurchaseDate.AddYears(3);

        if (toOld <= DateTime.Now || difference.TotalDays <= 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nBrand:" + MyPhone[i].Brand + " \nModel: " + MyPhone[i].ModelName + " \nPurchase date:" + MyPhone[i].PurchaseDate + "\nOffie: " + MyPhone[i].Office.OfficeName);
            Console.WriteLine("Days left: " + Math.Floor(difference.TotalDays));
        }
        else if (difference.TotalDays >= 0 && difference.TotalDays <= 90)
        {

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nBrand:" + MyPhone[i].Brand + " \nModel: " + MyPhone[i].ModelName + " \nPurchase date:" + MyPhone[i].PurchaseDate + "\nOffie: " + MyPhone[i].Office.OfficeName);
            Console.WriteLine("Days left: " + Math.Floor(difference.TotalDays));
        }
        else
        {
            Console.WriteLine("\nBrand:" + MyPhone[i].Brand + " \nModel: " + MyPhone[i].ModelName + " \nPurchase date:" + MyPhone[i].PurchaseDate + "\nOffie: " + MyPhone[i].Office.OfficeName);
            Console.WriteLine("Days left: " + Math.Floor(difference.TotalDays));
        }
        Console.ResetColor();
    }
}

void Lifespan()
{
    DateTime currentdate = DateTime.Now;    // Get the current date,  want to modifiy this one
    DateTime expirationDate = currentdate.AddYears(3);

    TimeSpan timeRemaining = expirationDate - currentdate;
    Console.WriteLine("Time remaining: " + timeRemaining + " \nCurrent date: " + currentdate.ToString() + " \nOld date:" + expirationDate);
}

class Office
{
    public Office(string officeName, string currency)
    {
        OfficeName = officeName;
        Currency = currency;
    }

    public string OfficeName { get; set; }
    public string Currency { get; set; }
}


class Computer
{
    public Computer(string brand, string modelName, DateTime purchaseDate, int price, Office office)
    {
        Brand = brand;
        ModelName = modelName;
        PurchaseDate = purchaseDate;
        Price = price;
        Office = office;
    }

    public string Brand { get; set; }
    public string ModelName { get; set; }
    public DateTime PurchaseDate { get; set; }
    public int Price { get; set; }
    public Office Office { get; set; }

}

class Phone
{
    public Phone(string brand, string modelName, DateTime purchaseDate, int price, Office office)
    {
        Brand = brand;
        PurchaseDate = purchaseDate;
        Price = price;
        ModelName = modelName;
        Office = office;
    }
    public string Brand { get; set; }
    public DateTime PurchaseDate { get; set; }
    public int Price { get; set;}
    public string ModelName { get; set;}
    public Office Office { get; set;}


}

