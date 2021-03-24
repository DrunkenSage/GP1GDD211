using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    private Inventory inventory;
    [SerializeField] private UI_Inventory uiInventory;
    
    private void Awake()
    {
        inventory = new Inventory();
        uiInventory.SetInventory(inventory);
        ItemWorld.SpawnItemWorld(new Vector3(1, 1), new Item { itemType = Item.ItemType.Sword, amount = 1 });
        ItemWorld.SpawnItemWorld(new Vector3(-1, 1), new Item { itemType = Item.ItemType.Journal, amount = 1 });
    }
    private void OnTriggerEnter2D(Collider2D collider)
    {
        ItemWorld itemWorld = collider.GetComponent<ItemWorld>();
        if(itemWorld != null)
        {
            Debug.Log("Colliding");
            inventory.AddItem(itemWorld.GetItem());
            itemWorld.DestroySelf();
        }
    }
}
