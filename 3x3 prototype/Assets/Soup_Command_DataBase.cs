using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;
using System.IO;

[System.Serializable]
public class Item_list_Soup_Command
{
    public Item_list_Soup_Command(string _Type, string _Name)
    {
        Type = _Type; Name = _Name;
    }

    public string Type, Name;
}

public class Soup_Command_DataBase : MonoBehaviour
{
    public TextAsset ItemDatabase;
    public List<Item_list_Soup_Command> aiItemList, SoupAnswer_Command_ItemList;
    public int moveCount = 0;

    public double score = 0;

    void Start()
    {

        //현재 아이템 리스트 불러오기
        string[] line = ItemDatabase.text.Substring(0, ItemDatabase.text.Length - 1).Split('\n');
        //Debug.Log(line.Length);
        for (int i = 0; i < line.Length; i++)
        {
            string[] row = line[i].Split('\t');
            aiItemList.Add(new Item_list_Soup_Command(row[0], row[1]));
        }



        Save();

        Load();
    }

    void Save()
    {
        string jdata = JsonConvert.SerializeObject(aiItemList);
        File.WriteAllText(Application.dataPath + "/etc/Soup_Command_Answer_DataBase_Another.txt", jdata);
    }

    void Load()
    {
        string jdata = File.ReadAllText(Application.dataPath + "/etc/Soup_Command_Answer_DataBase_Another.txt");
        SoupAnswer_Command_ItemList = JsonConvert.DeserializeObject<List<Item_list_Soup_Command>>(jdata);
    }


}