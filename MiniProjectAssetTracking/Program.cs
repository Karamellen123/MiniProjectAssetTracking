// See https://aka.ms/new-console-template for more information

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
*/



Computer comp1 = new Computer("Apple", "MACBOOK", "US", date1, 970);
Computer comp2 = new Computer("Windows", "Elitbook", "US", date2, 800);
Computer comp3 = new Computer("Windows", "HP", "US", date3, 840);
Computer comp4 = new Computer("Lenovo", "Yoga 730", "US", date1, 300);
MyComputer.Add(comp1);
MyComputer.Add(comp2);
MyComputer.Add(comp3);
MyComputer.Add(comp4);


Phone phone1 = new Phone("Huawei", "Huawei p9 lite", "US", date2, 300);
Phone phone2 = new Phone("Apple", "Iphone 9", "US", date3, 1000);
Phone phone3 = new Phone("Samsung", "Samsung galaxy 4", "US", date1, 200);
Phone phone4 = new Phone("Google", "Google Pixle pro 8", "US", date3, 150);
Phone phone5 = new Phone("Apple", "Iphone 2", "US", date2, 500);
MyPhone.Add(phone1);
MyPhone.Add(phone2);
MyPhone.Add(phone3);
MyPhone.Add(phone4);
MyPhone.Add(phone5);

DisplayLists();


void DisplayLists()
{
    //Sorter by purchase date
    MyComputer = MyComputer.OrderBy(c => c.PurchaseDate).ToList();

    for (int i = 0; i < MyComputer.Count(); i++)
    {
        DateTime temp = MyComputer[i].PurchaseDate.AddYears(3);
        TimeSpan difference = temp - DateTime.Today;

        DateTime toOld = MyComputer[i].PurchaseDate.AddYears(3);
        
        if (toOld <= DateTime.Now || difference.TotalDays <= 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nBrand:" + MyComputer[i].Brand + " \nModel: " + MyComputer[i].ModelName + " \nPurchase date:" + MyComputer[i].PurchaseDate);
            Console.WriteLine("Days left: " + Math.Floor(difference.TotalDays));
        }
        else if (difference.TotalDays >= 0 && difference.TotalDays <= 90)
        {
            
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nBrand:" + MyComputer[i].Brand + " \nModel: " + MyComputer[i].ModelName + " \nPurchase date:" + MyComputer[i].PurchaseDate);
            Console.WriteLine("Days left: " + Math.Floor(difference.TotalDays));
        }
        else
        {
            Console.WriteLine("\nBrand:" + MyComputer[i].Brand + " \nModel: " + MyComputer[i].ModelName + " \nPurchase date:" + MyComputer[i].PurchaseDate);
            Console.WriteLine("Days left: " + Math.Floor(difference.TotalDays));
        }
        Console.ResetColor();
    }
    Console.WriteLine("_________________________________________________________________");

    MyPhone = MyPhone.OrderBy(p => p.PurchaseDate).ToList();

    for (int i = 0; i < MyPhone.Count(); i++)
    {
        DateTime temp = MyPhone[i].PurchaseDate.AddYears(3);
        TimeSpan difference = temp - DateTime.Today;
        DateTime toOld = MyPhone[i].PurchaseDate.AddYears(3);

        if (toOld <= DateTime.Now || difference.TotalDays <= 0)
            textPhone(i, difference, 1);
        else if (difference.TotalDays >= 0 && difference.TotalDays <= 90)
            textPhone(i, difference, 2);
        else
            textPhone(i, difference, 3);
        Console.ResetColor();
    }
    Console.ReadKey();
}
void textPhone(int index, TimeSpan difference, int state)
{
    if(state == 1)
        Console.ForegroundColor = ConsoleColor.Red;
    if(state == 2)
        Console.ForegroundColor = ConsoleColor.Yellow;
    else
        Console.ResetColor();
    Console.WriteLine("\nBrand:" + MyPhone[index].Brand + " \nModel: " + MyPhone[index].ModelName + " \nPurchase date:" + MyPhone[index].PurchaseDate);
    Console.WriteLine("Days left: " + Math.Floor(difference.TotalDays));
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
    public Phone(string brand, string modelName, string office, DateTime purchaseDate, int price )
    {
        Brand = brand;
        PurchaseDate = purchaseDate;
        Price = price;
        ModelName = modelName;
    }
    public string Brand { get; set; }
    public DateTime PurchaseDate { get; set; }
    public int Price { get; set;}
    public string ModelName { get; set;}

}