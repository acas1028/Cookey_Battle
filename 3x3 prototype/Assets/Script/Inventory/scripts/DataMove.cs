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

    public GameObject Slime;

    public GameObject Dragon;

    public GameObject ingame_step_object;

    public GameObject fieldobject;

    public int ingame_step;

    public int field_score;

    public bool space_onoff = false;

    public bool isinventorystart = false;

    public bool issoup;

    public bool isslime;

    public bool isDragon;

   


    
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
            
        }

        /*if (ingame_step_object.GetComponent<CompareActiveAnswer>().isPossibleDestroy == true)
        {
            DataMoving();
            ingame_step_object.GetComponent<CompareActiveAnswer>().isPossibleDestroy = false;
            

        }*/



    }

    public void DataMoving()
    {
        fieldobject.GetComponent<FieldObjectScript>().SetitemList(myObject.GetComponent<DataSpace>().item_List);
        data_GameManager.moveCount--;
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
        if (issoup == true)
        {

            if (soup.GetComponent<Soup_DataBase>().GetItemName(ingame_step_object.GetComponent<CompareActiveAnswer>().Ingredient_Count) == myObject.GetComponent<DataSpace>().item_List.Name)
            {
                
                fieldobject.GetComponent<FieldObjectScript>().SetFieldScore((fieldobject.GetComponent<FieldObjectScript>().fieldScore + myObject.GetComponent<DataSpace>().item_List.score));
            }
            else
            {
                fieldobject.GetComponent<FieldObjectScript>().SetFieldScore((fieldobject.GetComponent<FieldObjectScript>().fieldScore + 0));
            }
        }

        if (isslime == true)
        {

            if (Slime.GetComponent<SlimeDatabase>().GetItemName(ingame_step_object.GetComponent<CompareActiveAnswer>().Ingredient_Count) == myObject.GetComponent<DataSpace>().item_List.Name)
            {
                
                fieldobject.GetComponent<FieldObjectScript>().SetFieldScore((fieldobject.GetComponent<FieldObjectScript>().fieldScore + myObject.GetComponent<DataSpace>().item_List.score));
            }
            else
            {
                fieldobject.GetComponent<FieldObjectScript>().SetFieldScore((fieldobject.GetComponent<FieldObjectScript>().fieldScore + 0));
            }
        }

        if(isDragon)
        {
            if (Dragon.GetComponent<Dragon_Database>().GetItemName(ingame_step_object.GetComponent<CompareActiveAnswer>().Ingredient_Count) == myObject.GetComponent<DataSpace>().item_List.Name)
            {
                
                fieldobject.GetComponent<FieldObjectScript>().SetFieldScore((fieldobject.GetComponent<FieldObjectScript>().fieldScore + myObject.GetComponent<DataSpace>().item_List.score));
            }
            else
            {
                fieldobject.GetComponent<FieldObjectScript>().SetFieldScore((fieldobject.GetComponent<FieldObjectScript>().fieldScore + 0));
            }
        }

    }
}
