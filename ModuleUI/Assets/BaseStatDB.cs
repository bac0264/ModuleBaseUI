using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BaseStatDB : MonoBehaviour
{
    public static BaseStatDB Instance;
    public List<IconList> spriteList;
    public List<BackgroundList> backgroundList;

    private void Awake()
    {
        if (Instance == null) Instance = this;
    }
    public Sprite GetIcon(int TYPE, int TypeOfStat)
    {
        if (TYPE >= spriteList.Count) return null;
        if (TypeOfStat >= spriteList[TYPE].sprites.Count) return null;
        return spriteList[TYPE].sprites[TypeOfStat];
    }
    public Sprite GetBackground(int type, int color = 0)
    {
        if (type >= backgroundList.Count) return null;
        if (color >= backgroundList[type].sprites.Count) return null;
        return backgroundList[type].sprites[color];
    }
}
[System.Serializable]
public class IconList
{
    public List<Sprite> sprites;
}
[System.Serializable]
public class BackgroundList
{
    public List<Sprite> sprites;
}