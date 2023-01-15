using UnityEngine;

[System.Serializable]
public class Item
{
    public string name;
   
    public int value;
    public int weight;
    public bool stackable;
    public GameObject item;
    public bool questItem;
   

    public Item(string name, int value, int weight, bool stackable,GameObject item, bool questItem)
    {
        this.name = name;
        this.value = value;
        this.weight = weight;
        this.stackable = stackable;
        this.item = item;
        this.questItem = questItem;
      
    }
}