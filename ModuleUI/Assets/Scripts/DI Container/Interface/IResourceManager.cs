using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public interface IResourceManager
{
    List<ResourceStat> RESOURCE_LIST
    {
        set;
        get;
    }

    ResourceStat GetResourceWithType(BaseStat.Type type);
    void SetupResourceForTheFirst();
    /// <summary>
    /// This function save all Resource.
    /// Chuc nang nay luu tat ca cac resource lai
    /// </summary>
    void SaveAllResource();
    /// <summary>
    /// Save each element based on type of resource.
    /// Luu moi phan tu dua vao loai tai nguyen 
    /// </summary>
    void LoadAllResource();
}
