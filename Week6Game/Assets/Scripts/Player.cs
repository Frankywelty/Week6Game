using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character
{
    public List<Item> Inventory { get; set; } //a list that holds item objects (player inventory)

    void Awake()
    {
        Inventory = new List<Item>(); //Initialize Inventory as a new, empty list
    }

    public void CollectItem(Item item) //Method to add item to a players inventory
    {
        Inventory.Add(item); //add provided item to inventory list
        Debug.Log(characterName + " picked up: " + item.Name); //Write what item was picked up
    }

    public void ShowInventory() //Method to show current items in Inventory
    {
        Debug.Log(""); // prints blank line
        Debug.Log(characterName + "'s Inventory:"); // player name followed by "'s" Inventory

        if (Inventory.Count == 0) //check for empty inventory
        {
            Debug.Log("(empty)"); //print empty
        }
        else
        {
            foreach (Item item in Inventory) //If there are items, loop through each item in the inventory list
            {
                Debug.Log("- " + item.Name); //Print each items name
            }
        }
    }
}
