using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine.UI;

public class ResourceManager : IResourceManager
{
    IDataService dataService;
    List<ResourceStat> ResourceList;
    public List<ResourceStat> RESOURCE_LIST
    {
        set
        {
            ResourceList = value;
        }
        get
        {
            return ResourceList;
        }
    }
    public ResourceManager(IDataService dataService)
    {
        this.dataService = dataService;
        LoadAllResource();
    }

    public void SetupResourceForTheFirst()
    {
    }
    public void LoadAllResource()
    {
       // RESOURCE_LIST = dataService.GetDataListWithType<BaseStat, ResourceStat>(dataService.GetDataSave());
    }
    public void SaveAllResource()
    {
        dataService.Save();
    }
    public ResourceStat GetResourceWithType(BaseStat.Type type)
    {
        for(int i = 0; i < RESOURCE_LIST.Count; i++)
        {
            if (RESOURCE_LIST[i].TYPE == (int) type) return RESOURCE_LIST[i];
        }
        return null;
    }
    public void AddPrice(ResourceStat price) { 
    }
}
