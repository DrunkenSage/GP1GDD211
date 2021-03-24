using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Inventory : MonoBehaviour
{
    private Inventory inventory;
    public Transform itemSlotContainer;
    public Transform itemSlotTemplate;
    public Image sprite;

   
    public void SetInventory(Inventory inventory)
    {
        this.inventory = inventory;
        RefreshInventoryItem();
    }
    private void RefreshInventoryItem()
    {
        int x = -8;
        int y = 0;
        int amount = 0;
        float itemsSlotCellSize = 30f;
        foreach (Item item in inventory.GetItemList())
        {
            RectTransform itemSlotRectTransform = Instantiate(itemSlotTemplate, itemSlotContainer).GetComponent<RectTransform>();
            itemSlotRectTransform.gameObject.SetActive(true);
            itemSlotRectTransform.anchoredPosition = new Vector2(x * itemsSlotCellSize, y * itemsSlotCellSize);
            Image image = sprite.GetComponent<Image>();
            image.sprite = item.GetSprite();
            x+=4;
            amount++;
            if (x > 16 && amount<=3)
            {
                x = 0;
                y++;
            }
            
        }
    }
}
