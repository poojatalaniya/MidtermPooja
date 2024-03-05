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


