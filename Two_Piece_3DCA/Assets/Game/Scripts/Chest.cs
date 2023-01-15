using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Chest : MonoBehaviour
{
    public Inventory inventory;
    public int requiredAmount=5;
    public bool opened;
    public void Start()
    {
        opened = false;
    }
    public bool OnMouseDown()
    {
        if (inventory.NumberOfItems() == requiredAmount)
        {
            opened = true;
        }
        return opened;
    }
}
