using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadDataHelper : MonoBehaviour
{

    public TextAsset dataPrice;
    public SOPrice so;
    public void LoadData()
    {
        var _dataPrice = CSVReader.Read(dataPrice);
        so.LoadPrice(_dataPrice);
    }

}