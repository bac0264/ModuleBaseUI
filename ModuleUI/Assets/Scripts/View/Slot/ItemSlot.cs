using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ItemSlot : _ActionSlotSetup<ItemSlot, ItemStat>
{
    public Text TXT_VALUE;
    public Image IMG_ICON;
    public Image IMG_BG;

    public override ItemStat DATA { 
        get => base.DATA; set
        {
            base.DATA = value;

            TXT_VALUE.text = DATA.VALUE.ToString();
            IMG_ICON.sprite = BaseStatDB.Instance.GetIcon(DATA.ITEM_TYPE, DATA.ITEM_ID);
            IMG_BG.sprite = BaseStatDB.Instance.GetBackground(DATA.ITEM_TYPE, DATA.ITEM_COLOR);
        }
    
    }
    public override void OnPointerClick(PointerEventData eventData)
    {
        base.OnPointerClick(eventData);
    }
}
