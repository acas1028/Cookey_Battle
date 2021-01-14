using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;
using System.IO;

[System.Serializable]
public class Item_list
{
    public Item_list(string _Type, string _Name, string _Explanation, bool _isUsing)
    {
        Type = _Type; Name = _Name; Explanation = _Explanation; isUsing = _isUsing;
    }

    public string Type, Name, Explanation;
    public bool isUsing;


}

public class Data_GameManager : MonoBehaviour
{
    public TextAsset ItemDatabase;
    public List<Item_list> aiItemList, warehouseItemList;
    public int moveCount = 0;

    void Start()
    {
        //현재 아이템 리스트 불러오기
        string[] line = ItemDatabase.text.Substring(0, ItemDatabase.text.Length - 1).Split('\n');
        for (int i = 0; i < line.Length; i++)
        {
            string[] row = line[i].Split('\t');
            aiItemList.Add(new Item_list(row[0], row[1], row[2], row[3] == "True"));
        }

        Save();

        Load();
    }

    void Save()
    {
        string jdata = JsonConvert.SerializeObject(aiItemList);
        File.WriteAllText(Application.dataPath + "/etc/myItemText.txt", jdata);
    }

    void Load()
    {
        string jdata = File.ReadAllText(Application.dataPath + "/etc/myItemText.txt");
        warehouseItemList = JsonConvert.DeserializeObject<List<Item_list>>(jdata);
    }
}