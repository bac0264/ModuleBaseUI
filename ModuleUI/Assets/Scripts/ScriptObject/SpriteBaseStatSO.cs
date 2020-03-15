using UnityEngine;
using System.Collections;
using System.Collections.Generic;
[CreateAssetMenu(fileName = "SpriteBaseStatSO", menuName = "ScriptObject/SpriteBaseStatSO", order = 1)]
public class SpriteBaseStatSO : ScriptableObject
{
    public List<Sprite> sprites;
    public void GetIcon(int type, int idOfType)
    {

    }
    public void GetBackground(int type, int idOfType, int color = -1)
    {

    }
}
