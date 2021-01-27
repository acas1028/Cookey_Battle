using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataMove : MonoBehaviour
{
    public GameObject Field;

    public Data_GameManager data_GameManager;

    public GameObject myObject;

    public GameObject movingObject;

    public GameObject objectScript;

    public GameObject soup;

    public int ingame_step;

    public GameObject ingame_step_object;

    public GameObject fieldobject;

    public int field_score;

    public bool space_onoff = false;


    
    void Start()
    {
        ingame_step = ingame_step_object.GetComponent<CompareActiveAnswer>().GetIngameStep();

        field_score = fieldobject.GetComponent<FieldObjectScript>().GetFieldScore();
    }

    // Update is called once per frame
    void Update()
    {
         
            if (Input.GetKeyDown(KeyCode.Space))
            {
                space_onoff = true;
                DataMoving();
            }
        
        
    }

    void DataMoving()
    {
        fieldobject.GetComponent<FieldObjectScript>().SetitemList(myObject.GetComponent<DataSpace>().item_List);
        Destroy(myObject);
        Destroy(movingObject);
        //    myObject.transform.SetParent(Field.transform);
        //    myObject.transform.position = Field.transform.position;
        //movingObject.transform.SetParent(Field.transform);
        //movingObject.transform.position = Field.transform.position;
        
    }

    public void Score_Calculation()
    {
        objectScript.GetComponent<FieldObjectScript>().GetFieldScore();
    }

    public void Name_Compare()
    {
        if ( soup.GetComponent<Soup_DataBase>().GetItemName(ingame_step - 1) == myObject.GetComponent<DataSpace>().item_List.Name)
        {
            fieldobject.GetComponent<FieldObjectScript>().SetFieldScore((field_score + myObject.GetComponent<DataSpace>().item_List.score) / 2);
        }
        else 
        {
            fieldobject.GetComponent<FieldObjectScript>().SetFieldScore((field_score + 0) / 2);
        }
    }
}
