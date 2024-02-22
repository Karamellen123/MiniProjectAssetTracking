// See https://aka.ms/new-console-template for more information





Lifespan();

void Lifespan()
{
    DateTime currentdate = DateTime.Now;    // Get the current date,  want to modifiy this one
    DateTime expirationDate = currentdate.AddYears(3);

    TimeSpan timeRemaining = expirationDate - currentdate;
    Console.WriteLine("Time remaining: " + timeRemaining + " \nCurrent date: " + currentdate.ToString() + " \nOld date:" + expirationDate);
}

Console.ReadLine();




class Computer
{
    public Computer(string computerType, DateTime purchaseDate, int price, string modelName) 
    {
        ComputerType = computerType;
        PurchaseDate = purchaseDate;
        Price = price;
        ModelName = modelName;
    }
    public string ComputerType { get; set;}
    public DateTime PurchaseDate { get; set;}
    public int Price { get; set;}
    public string ModelName { get; set;}



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