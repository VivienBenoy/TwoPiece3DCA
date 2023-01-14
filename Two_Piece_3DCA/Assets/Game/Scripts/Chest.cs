using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Chest : MonoBehaviour
{
    public Inventory inventory;
    public Item requiredItem;
    public int requiredAmount;
    public bool opened;
    public void Start()
    {
        opened = false;
    }
    public bool OnMouseDown()
    {
        if (inventory.CountItem(requiredItem) == requiredAmount)
        {
            opened = true;
        }
        return opened;
    }
}
