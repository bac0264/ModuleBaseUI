using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class Test : MonoBehaviour
{
    public SOPrice soPrice;
    void Start()
    {
        DIContainer.SetModule<IDataService, DataService>();
        DIContainer.SetModule<IResourceManager, ResourceManager>();
        DIContainer.SetModule<IItemManager, ItemManager>();

        //IResourceManager dataResource = DIContainer.GetModule<IResourceManager>();
        // IItemManager itemResource = DIContainer.GetModule<IItemManager>();
        //    List<ResourceStat> resourceData = dataResource.RESOURCE_LIST;
        //    List<ItemStat> itemData = itemResource.ITEM_LIST;
        //    //List<ItemStat> _data = d
        //    //Debug.Log("Item");
        //    for (int i = 0; i < itemData.Count; i++)
        //    {
        //        Debug.Log(JsonUtility.ToJson(itemData[i]));
        //        itemData[i].VALUE = 10;
        //        Debug.Log(itemData[i].ID);
        //    }
        //    //List<ResourceStat> _data = dataService.GetDataListWithType<BaseStat, ResourceStat>(dataService.GetDataSave());
        //    Debug.Log("Resource");
        //    for (int i = 0; i < resourceData.Count; i++)
        //    {
        //        Debug.Log(JsonUtility.ToJson(resourceData[i]));
        //        resourceData[i].VALUE = i;

        //        Debug.Log(resourceData[i].ID);
        //    }
        //    dataResource.SaveAllResource();
        //}
    }
}
