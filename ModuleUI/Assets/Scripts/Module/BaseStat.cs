using UnityEngine;
using System.Collections;
[System.Serializable]
public class BaseStat
{
    public enum Type{
        Resource,
        ITEM,
    }
    [System.NonSerialized]
   // public Type type;

    public int ID;
    public string NAME;
    public long VALUE;
    public int TYPE;
    public BaseStat(long value)
    {
        NAME = "BaseStat";
        this.VALUE = value;
        ID = 0;
    }
    public virtual void addprice() { }
}
