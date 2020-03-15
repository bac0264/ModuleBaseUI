using UnityEngine;
using System.Collections;

[System.Serializable]
public class ItemStat : BaseStat
{
    public enum TypeOfItem
    {
        WEAPON,
        ARMOR,
    }
    //[System.NonSerialized]
    public int ITEM_COLOR;
    public bool ITEM_EQUIP;
    public int ITEM_ID;
    public int ITEM_TYPE;
    public ItemStat(long value, TypeOfItem typeOfItem, int typeOfItemID) : base(value)
    {
        this.ITEM_TYPE = (int)typeOfItem;
        this.ITEM_ID = typeOfItemID;
        this.ITEM_COLOR = 0;
        this.ITEM_EQUIP = false;
        this.TYPE = (int) Type.ITEM;
        NAME = "ItemStat";
    }
}
