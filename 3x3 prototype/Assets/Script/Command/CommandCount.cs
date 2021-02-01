using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CommandCount : MonoBehaviour
{
    public GameObject soupCommandDatabase;

    public GameObject commandComparison;

    public int count;

    public Text text;

    private void Update()
    {
        count = soupCommandDatabase.GetComponent<Soup_Command_DataBase>().HisCount -commandComparison.GetComponent<ComandComparison>().CommandComparisonCount;


        text.text = count.ToString();
    }
}
