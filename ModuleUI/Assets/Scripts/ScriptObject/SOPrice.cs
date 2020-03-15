using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "SOPrice", menuName = "ScriptObject/SOPrice", order = 1)]
public class SOPrice : ScriptableObject
{
    public List<PriceData> priceList;
    //public DataSave<BaseStat> dataList;
    public void LoadPrice(List<Dictionary<string, string>> dataCSV)
    {
        priceList = new List<PriceData>();
        for (int i = 0; i < dataCSV.Count; i++)
        {
            PriceData _data = new PriceData(dataCSV[i]);
            priceList.Add(_data);
        }
        DataSave<BaseStat> dataList = BacJson.FromJson<BaseStat, ResourceStat, ItemStat>(priceList[0].json);
        string _json = BacJson.ToJson<BaseStat>(dataList);
        Debug.Log(_json);
    }
}
[System.Serializable]

public class PriceData
{
    public int id;
    public string json;

    public PriceData(Dictionary<string, string> data)
    {
        int.TryParse(data["ID"], out id);
        json = data["PRICE"].Replace("[{", "{").Replace("}]", "}").Replace(';', ',').Replace("},", "}|");
    }
}

