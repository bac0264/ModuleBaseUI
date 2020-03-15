using UnityEngine;
using System.Collections;
using TMPro;

public class FontsManager : MonoBehaviour
{
    public static FontsManager instance;
    // Ro is vietnamese, Go is english
    public TMP_FontAsset Ro_fontForBtn;
    public TMP_FontAsset Ro_fontForSetting;
    public TMP_FontAsset Ro_fontForLose;
    public TMP_FontAsset Go_fontForBtn;
    public TMP_FontAsset Go_fontForSetting;
    public TMP_FontAsset Go_fontForLose;
    public Font vietnamese;
    public Font English;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this);
        }
        else { Destroy(this); }
    }
    public Font GetFontText(string language)
    {
        if (language.Equals("0")) return vietnamese;
        else return English;
    }
    public TMP_FontAsset GetFontTextMesh(string language, string type)
    {
        if (language.Equals("0"))
        {
            if (type.Equals("Btn")) return Ro_fontForBtn;
            else if (type.Equals("Setting")) return Ro_fontForSetting;
            else return Ro_fontForLose;
        }
        else
        {
            if (type.Equals("Btn")) return Go_fontForBtn;
            else if (type.Equals("Setting")) return Go_fontForSetting;
            else return Go_fontForLose;
        }
    }
}
