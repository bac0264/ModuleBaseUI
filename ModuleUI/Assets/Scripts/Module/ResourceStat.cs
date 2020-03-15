using UnityEngine;
using System.Collections;

[SerializeField]
public class ResourceStat : BaseStat
{
    public enum TypeOfResource
    {
        GOLD,
        GEM,
    }
    [System.NonSerialized]
    public bool RESOURCE_CHECK;
    public int RESOURCE_TYPE;
    public ResourceStat(long value, TypeOfResource typeOfResource) : base(value)
    {
        this.RESOURCE_TYPE =(int) typeOfResource;
        NAME = "ResourceStat";
        RESOURCE_CHECK = true;
        this.TYPE = (int)Type.Resource;
    }

    //    public override AddPrice(IResourceManager irm)
    //    {

    //    }
}
