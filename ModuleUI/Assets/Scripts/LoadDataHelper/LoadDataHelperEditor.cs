using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

#if UNITY_EDITOR
[CustomEditor(typeof(LoadDataHelper))]
[CanEditMultipleObjects]
public class LoadDataHelperEditor : Editor
{

    public override void OnInspectorGUI()
    {
        LoadDataHelper myscript = (LoadDataHelper)target;

        if (GUILayout.Button("Load Data"))
        {
            myscript.LoadData();
            EditorUtility.SetDirty(myscript.dataPrice);
        }

        base.OnInspectorGUI();
    }

}
#endif