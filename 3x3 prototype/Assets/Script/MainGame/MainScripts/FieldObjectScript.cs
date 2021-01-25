using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FieldObjectScript : MonoBehaviour
{
    int     itemNumber;
    int     fieldScore;
    // Start is called before the first frame update
    void Start()
    {
        itemNumber = 0;
        fieldScore = 76;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int GetFielditemNumber()
    {
        return itemNumber;
    }

    public int GetFieldScore()
    {
        return fieldScore;
    }

    public void SetFielditemNumber(int itemNum)
    {
        itemNumber = itemNum;
    }

    public void SetFieldScore(int score)
    {
        fieldScore = score;
    }
}
