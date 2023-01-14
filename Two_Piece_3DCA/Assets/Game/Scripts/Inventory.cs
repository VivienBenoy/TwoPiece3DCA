using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    // Start is called before the first frame update
    public List<Item> items = new List<Item>();
    public int capacity = 20;

    public void AddItem(Item item)
    {
        if (items.Count >= capacity)
        {
            // Inventory is full
            return;
        }
        items.Add(item);
    }

    public void RemoveItem(Item item)
    {
        items.Remove(item);
    }

    public bool HasItem(Item item)
    {
        return items.Contains(item);
    }
    public int CountItem(Item item)
    {
        return items.Count(i => i.name == item.name);
    }
}
