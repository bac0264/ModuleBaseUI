using UnityEngine;
using System.Collections;
using System;

// T is itemSlot, T1 is itemStat
[System.Serializable]
public class _SlotListSetup<T,T1> : MonoBehaviour
{
    public _ActionSlotSetup<T,T1>[] slotList;

    public Action<_ActionSlotSetup<T,T1>> OnRightClick;
    public virtual void OnValidate()
    {
        if (slotList == null || slotList.Length == 0) slotList = GetComponentsInChildren<_ActionSlotSetup<T,T1>>();
    }
    public virtual void Setup()
    {
        if (slotList == null || slotList.Length == 0) slotList = GetComponentsInChildren<_ActionSlotSetup<T, T1>>();
    }
    public virtual void SetupSlotList(T1[] dataBase)
    {
        for(int i = 0; i < dataBase.Length; i++)
        {
            slotList[i].DATA = dataBase[i];
            OnRightClick += slotList[i].OnRightClickEvent;
        }
    }

}
