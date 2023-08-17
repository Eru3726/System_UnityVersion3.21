using System;
using UnityEngine;

[Serializable]
[CreateAssetMenu(fileName = "Item", menuName = "DataBase/CreateItem")]
public class Item : ScriptableObject
{
    public Type itemType;               //���
    public String itemName;             //���O
    public Sprite itemSprite;           //�摜
    public int itemResilience;          //�񕜗�

    public enum Type
    {
        SmallHealingPotion,
        MediumHealingPotion,
        LargeHealingPotion,
    }

    public Item(Item item)
    {
        this.itemType = item.itemType;
        this.itemName = item.itemName;
        this.itemSprite = item.itemSprite;
        this.itemResilience = item.itemResilience;
    }
}