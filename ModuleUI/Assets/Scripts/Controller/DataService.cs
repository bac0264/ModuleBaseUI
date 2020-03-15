using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;

public class DataService : IDataService
{
    DataSave<BaseStat> BaseStat_dataSave;
    public DataService()
    {
        if (PlayerPrefs.GetInt("First", 0) == 0)
        {
            BaseStat_dataSave = new DataSave<BaseStat>();
            BaseStat_dataSave.results.Add(new ResourceStat(1, ResourceStat.TypeOfResource.GEM));
            BaseStat_dataSave.results.Add(new ResourceStat(2, ResourceStat.TypeOfResource.GOLD));
            for (int i = 0; i < 20; i++)
            {
                if (i % 3 == 0)
                    BaseStat_dataSave.results.Add(new ItemStat(1, ItemStat.TypeOfItem.ARMOR, 0));
                else if (i % 3 == 2) BaseStat_dataSave.results.Add(new BaseStat(2));
            }
            Save();
            PlayerPrefs.SetInt("First", 1);
        }
        else
            Load();
    }
    public DataSave<BaseStat> GetDataSave()
    {
        return BaseStat_dataSave;
    }
    public void Save()
    {
        string data = BacJson.ToJson<BaseStat>(BaseStat_dataSave);
        Debug.Log("data: " + data);
        PlayerPrefs.SetString("Data", data);
        Debug.Log(PlayerPrefs.GetString("Data"));
    }
    public void Load()
    {
        BaseStat_dataSave = BacJson.FromJson<BaseStat, ItemStat, ResourceStat>(PlayerPrefs.GetString("Data"));
        Debug.Log(PlayerPrefs.GetString("Data"));
    }
    public List<T1> GetDataListWithType<T, T1>(DataSave<T> data)
    {
        List<T1> dataList = new List<T1>();
        int index = 0;
        for (int i = 0; i < data.results.Count; i++)
        {
            if (data.results[i].GetType().GetField("NAME").GetValue(data.results[i]).Equals(typeof(T1).ToString()))
            {
                FieldInfo id = data.results[i].GetType().GetField("ID");
                if (id != null)
                {
                    id.SetValue(data.results[i], index);
                    index++;
                }
                dataList.Add((T1)(object)data.results[i]);
            }
        }
        return dataList;
    }
}

[System.Serializable]
public class DataSave<T>
{
    public List<T> results;
    public DataSave()
    {
        results = new List<T>();
    }
    public void Add(T b)
    {
        results.Add(b);
    }
}
