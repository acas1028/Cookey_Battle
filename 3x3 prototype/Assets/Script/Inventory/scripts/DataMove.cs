using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataMove : MonoBehaviour
{
    public GameObject[] InventorySlot;

    public Data_GameManager data_GameManager;

    public GameObject myObject;

    public GameObject movingObject;

   

    

    
    void Start()
    {
        
        InventorySlot = GameObject.FindGameObjectsWithTag("Slot");
        
    }

    // Update is called once per frame
    void Update()
    {
         
            if (Input.GetKeyDown(KeyCode.Space))
            {
                DataMoving();
            }
        
        
    }

    void DataMoving()
    {
        
            myObject.transform.SetParent(InventorySlot[data_GameManager.moveCount].transform);
            myObject.transform.position = InventorySlot[data_GameManager.moveCount].transform.position;
        movingObject.transform.SetParent(InventorySlot[data_GameManager.moveCount].transform);
        movingObject.transform.position = InventorySlot[data_GameManager.moveCount].transform.position;
        data_GameManager.moveCount++;

        
        
    }
}
