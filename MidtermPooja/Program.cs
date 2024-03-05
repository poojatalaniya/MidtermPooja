//Midterm Exam
//By Pooja Talaniya (8604569)-Ptalaniya4569@conestogac.on.ca

//Beginning correction of the code

using System;
public class InventoryItem
{
    // Properties
    public string ItemName { get; set; }
    public int ItemId { get; set; }
    public double Price { get; set; }
    public int QuantityInStock { get; set; }

    // Constructor
    public InventoryItem(string itemName, int itemId, double price, int quantityInStock)
    {
        // Initializing the properties with the values passed to the constructor.
        ItemName = itemName;
        ItemId = itemId;
        Price = price;
        QuantityInStock = quantityInStock;
    }
    // Methods

    // Updating the price of the item
    public void UpdatePrice(double newPrice)
    {
        Price = newPrice;
    }

    // Restocking the item
    public void RestockItem(int additionalQuantity)
    {
        QuantityInStock += additionalQuantity;
    }
    // Selling an item
    public void SellItem(int quantitySold)
    {
        if (QuantityInStock - quantitySold < 0)
        {
            Console.WriteLine("Not enough items in stock to sell.");
        }
        else
        {
            QuantityInStock -= quantitySold;
        }
    }

    // Checking if an item is in stock
    public bool IsInStock()
    {
        return QuantityInStock > 0;
    }
    // Printing item details
    public void PrintDetails()
    {
        Console.WriteLine($"Name: {ItemName}");
        Console.WriteLine($"ID: {ItemId}");
        Console.WriteLine($"Price: {Price}");
        Console.WriteLine($"Quantity in Stock: {QuantityInStock}");
    }
}
class Program
{
    static void Main(string[] args)
    {
        // Creating instances of InventoryItem
        InventoryItem item1 = new InventoryItem("Laptop", 101, 1200.50, 10);
        InventoryItem item2 = new InventoryItem("Smartphone", 102, 800.30, 15);

        // Printing details of all items
        Console.WriteLine("Item Details:");
        item1.PrintDetails();
        item2.PrintDetails();

        // Selling some items and then printing the updated details
        Console.WriteLine("\nSelling 5 Laptops...");
        item1.SellItem(5);
        Console.WriteLine("Updated Laptop Details:");
        item1.PrintDetails();

        Console.WriteLine("\nSelling 3 Smartphones...");
        item2.SellItem(3);
        Console.WriteLine("Updated Smartphone Details:");
        item2.PrintDetails();

        // Restocking an item and printing the updated details
        Console.WriteLine("\nRestocking 10 Laptops...");
        item1.RestockItem(10);
        Console.WriteLine("Updated Laptop Details:");
        item1.PrintDetails();

        // Checking if an item is in stock and printing a message accordingly
        Console.WriteLine("\nChecking if Laptop is in stock...");
        if (item1.IsInStock())
        {
            Console.WriteLine("Laptop is in stock.");
        }
        else
        {
            Console.WriteLine("Laptop is not in stock.");
        }

        Console.WriteLine("\nChecking if Smartphone is in stock...");
        if (item2.IsInStock())
        {
            Console.WriteLine("Smartphone is in stock.");
        }
        else
        {
            Console.WriteLine("Smartphone is not in stock.");
        }
    }
}



