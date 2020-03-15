using UnityEngine;
using System.Collections;

[System.Serializable]
public class _PanelSetup<T,T1> : MonoBehaviour
{
    public _SlotListSetup<T, T1> SlotListManager;

    public virtual void Setup()
    {
        if (SlotListManager == null) SlotListManager = GetComponentInChildren<_SlotListSetup<T, T1>>();
        if (SlotListManager != null) SlotListManager.Setup();
    }
    public virtual void OnValidate()
    {
        if (SlotListManager == null) SlotListManager = GetComponentInChildren<_SlotListSetup<T, T1>>();
    }
}
