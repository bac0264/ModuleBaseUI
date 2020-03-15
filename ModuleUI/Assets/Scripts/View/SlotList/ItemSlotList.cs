using UnityEngine;
using System.Collections;

public class ItemSlotList : _SlotListSetup<ItemSlot, ItemStat>
{
    public override void OnValidate()
    {
        base.OnValidate();
    }
    public override void SetupSlotList(ItemStat[] dataBase)
    {
        base.SetupSlotList(dataBase);
    }
}
