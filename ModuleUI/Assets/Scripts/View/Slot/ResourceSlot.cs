using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class ResourceSlot : _ActionSlotSetup<ResourceSlot,ResourceStat>
{
    public override ResourceStat DATA
    {
        get => base.DATA;
        set
        {
            base.DATA = value;
        }
    }
    public override void OnPointerClick(PointerEventData eventData)
    {
        base.OnPointerClick(eventData);
    }
}
