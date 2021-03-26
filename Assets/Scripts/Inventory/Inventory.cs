using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory 
{
    public event EventHandler OnItemListChanged;
    private readonly List<Item> itemList;
    public Inventory()
    {
        itemList = new List<Item>();
        
    }
    public void AddItem(Item item)
    {
        itemList.Add(item);
        OnItemListChanged?.Invoke(this, EventArgs.Empty);
        Debug.Log(itemList.Count);
    }
    public List<Item> GetItemList()
    {
        return itemList;
    }
}
