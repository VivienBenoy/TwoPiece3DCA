using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemModel : MonoBehaviour
{
    public Item item;
    public Inventory inventory;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (!inventory.HasItem(item))
            {
                inventory.AddItem(item);
                Destroy(gameObject);
            }
        }
    }
}
