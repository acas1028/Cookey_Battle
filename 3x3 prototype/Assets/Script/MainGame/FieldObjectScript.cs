using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FieldObjectScript : MonoBehaviour
{
    int     itemNumber;
    float   fieldScore;
    // Start is called before the first frame update
    void Start()
    {
        itemNumber = 0;
        fieldScore = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int getFielditemNumber()
    {
        return itemNumber;
    }

    public float getFieldScore()
    {
        return fieldScore;
    }
}
