using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CommandCount : MonoBehaviour
{
    public GameObject soupCommandDatabase;

    public Text text;

    private void Update()
    {
        text.text = soupCommandDatabase.GetComponent<Soup_Command_DataBase>().HisCount.ToString();
    }
}
