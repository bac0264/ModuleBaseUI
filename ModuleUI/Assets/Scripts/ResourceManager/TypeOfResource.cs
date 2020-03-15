using UnityEngine;
using System.Collections;
using System;

[System.Serializable]
public class TypeOfResource
{
    public enum Type
    {
        GOLD,
        GEM,
        STAMINA,
        EXP,
    }
    public Type type;
    public static Type ConvertStringToEnum(string str)
    {
        Type _type = (Type)Enum.Parse(typeof(Type), str);
        return _type;
    }

}
