using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class BaseSlot : _ActionSlotSetup<BaseSlot,BaseStat>
{
    public Text TXT_VALUE;
    public Image IMG_ICON;
    public Image IMG_BG;
    public override BaseStat DATA { 
        get => base.DATA;
        set
        {
            base.DATA = value;

            TXT_VALUE.text = DATA.VALUE.ToString();
            if (DATA is ItemStat)
            {
                Debug.Log(JsonUtility.ToJson(DATA));
                Debug.Log("ItemStat");
                ItemStat data = DATA as ItemStat;
                data.TYPE = (int)BaseStat.Type.ITEM;
                Debug.Log(DATA.ID);
                Debug.Log(data.ID);
                Debug.Log(data.ITEM_ID);
                Debug.Log(data.ITEM_COLOR);
                Debug.Log(data.ITEM_TYPE);
                Debug.Log(data.TYPE);
                IMG_ICON.sprite = BaseStatDB.Instance.GetIcon(data.TYPE, data.ITEM_TYPE);
                IMG_BG.sprite = BaseStatDB.Instance.GetBackground(data.TYPE, data.ITEM_COLOR);
            }
            else if (DATA is ResourceStat)
            {
                Debug.Log("ResourceStat");
                ResourceStat data = DATA as ResourceStat;
                data.TYPE = (int)BaseStat.Type.Resource;
                IMG_ICON.sprite = BaseStatDB.Instance.GetIcon(data.TYPE, data.RESOURCE_TYPE);
                IMG_BG.sprite = BaseStatDB.Instance.GetBackground(data.TYPE);
            }
        }        
    }
    public override void OnPointerClick(PointerEventData eventData)
    {
        base.OnPointerClick(eventData);
    }
}
