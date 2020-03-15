using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : IItemManager
{
    IDataService dataService;
    List<ItemStat> _ItemList;
    public ItemManager(IDataService dataService)
    {
        this.dataService = dataService;
        LoadAllItem();
    }
    public List<ItemStat> ITEM_LIST
    {
        set
        {
            _ItemList = value;
        }
        get
        {
            return _ItemList;
        }
    }

    public ItemStat GetItemWithID(int id)
    {
        if (id < ITEM_LIST.Count) return ITEM_LIST[id];
        return null;
    }

    public void LoadAllItem()
    {
       // ITEM_LIST = dataService.GetDataListWithType<BaseStat, ItemStat>(dataService.GetDataSave());
    }

    public void SaveAllItem()
    {
        dataService.Save();
    }

    // Start is called before the first frame update
}
