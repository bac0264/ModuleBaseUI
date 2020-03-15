using UnityEngine;
using System.Collections;

public class ResourceSlotList : _SlotListSetup<ResourceSlot, ResourceStat>
{
    public override void OnValidate()
    {
        base.OnValidate();
    }
    public override void SetupSlotList(ResourceStat[] dataBase)
    {
        base.SetupSlotList(dataBase);
    }
}
