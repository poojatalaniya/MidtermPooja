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


