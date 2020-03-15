using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public interface IItemManager
{
    List<ItemStat> ITEM_LIST
    {
        set;
        get;
    }

    ItemStat GetItemWithID(int id);
    void SaveAllItem();
    /// <summary>
    /// Save each element based on type of resource.
    /// Luu moi phan tu dua vao loai tai nguyen 
    /// </summary>
    void LoadAllItem();
}