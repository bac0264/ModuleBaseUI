using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ShowResource : MonoBehaviour
{

    public void UpdateResource()
    {
        ResourceText[] resourcesText = FindObjectsOfType<ResourceText>();
        foreach (ResourceText resource in resourcesText) resource.UpdateText();
    }
}
