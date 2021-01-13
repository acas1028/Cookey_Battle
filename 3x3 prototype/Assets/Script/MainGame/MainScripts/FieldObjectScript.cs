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
        fieldScore = 67;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int getFielditemNumber()
    {
        return itemNumber;
    }

    public int getFieldScore()
    {
        return fieldScore;
    }
}
