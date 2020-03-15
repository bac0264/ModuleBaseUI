using UnityEngine;
using System.Collections;

public class BaseSlotList : _SlotListSetup<BaseSlot, BaseStat>
{
    public override void OnValidate()
    {
        base.OnValidate();
    }
    public override void SetupSlotList(BaseStat[] dataBase)
    {
        base.SetupSlotList(dataBase);
    }
}
