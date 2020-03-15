using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class PopupFactory : MonoBehaviour
{
    public static PopupFactory instance;
    private Transform container;
    Dictionary<string, BasePopup> PopupList = new Dictionary<string, BasePopup>();
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(instance);
        }
        else
        {
            Destroy(this);
        }
    }

    public void UpdateContainer()
    {
        if (container == null) container = GameObject.FindGameObjectWithTag(KeySave.CONTAINER_POPUP).transform;
    }

    public bool ShowPopup(BasePopup.TypeOfPopup type, string message = null, BaseSlot slot = null )
    {
        if (PopupList.ContainsKey(type.ToString()))
        {
            return PopupList[type.ToString()];
        }
        bool check = InitPopup(type);
        return check;
    }
    public BasePopup GetPopup(BasePopup.TypeOfPopup type)
    {

        return null;
    }
    public bool InitPopup(BasePopup.TypeOfPopup type)
    {
        UpdateContainer();
        BasePopup popupNeed = Resources.Load<BasePopup>("Popup/" + type.ToString());
        if (popupNeed == null) return false;
        GameObject obj = Instantiate(popupNeed.gameObject, container);
        BasePopup popup = obj.GetComponent<BasePopup>();
        if (popup != null)
        {
            PopupList.Add(popup.type.ToString(), popup);
            popup.transform.SetAsLastSibling();
            popup.ShowPopup();
            return true;
        }
        return false;
    }
    public void HideAllPopup()
    {
        foreach(var popup in PopupList.Values)
        {
            popup.HidePopup();
        }
    }

}