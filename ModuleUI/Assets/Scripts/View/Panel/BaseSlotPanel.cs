using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseSlotPanel : _PanelSetup<BaseSlot,BaseStat>
{
    public SOPrice price;
    private void Start()
    {
        Setup();
        if (price.priceList.Count > 0)
        {
            Debug.Log(price.priceList.Count);
            DataSave<BaseStat> dataList = BacJson.FromJson<BaseStat, ResourceStat, ItemStat>(price.priceList[0].json);
            
            Debug.Log(BacJson.ToJson<BaseStat>(dataList));
            SlotListManager.SetupSlotList(dataList.results.ToArray());
        }
    }
    public override void Setup()
    {
        base.Setup();
    }
    public override void OnValidate()
    {
        base.OnValidate();
    }
}
