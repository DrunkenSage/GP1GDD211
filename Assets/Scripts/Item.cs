using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Item 
{
    public enum ItemType
    {
        Sword,
        Journal
    }
    public ItemType itemType;
    public int amount;

    public Sprite GetSprite()
    {
        switch (itemType) 
        {
            default:
            case ItemType.Sword: return ItemAssets.Instance.swordSprite;
            case ItemType.Journal: return ItemAssets.Instance.journalSprite;
        }

    }
}
