using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WareHouseDataMove : MonoBehaviour
{
    public GameObject[] InventorySlot;

    public Data_GameManager data_GameManager;

    public GameObject myObject;

    public GameObject movingObject;

    public DataSpace dataSpace;

    public List<GameObject> Children;

    public bool isemptySlots = false;

    public bool isInventoryMove = false;


    



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



        for (int i = 0; i < data_GameManager.moveCount; i++)
        {
            if (InventorySlot[i].transform.childCount == 0)
            {
                isemptySlots = true;
            }
        }



        if (isemptySlots == true)
        {
            for (int i = 0; i < data_GameManager.moveCount; i++)
            {

                
                    for (int k = i + 1; k <= data_GameManager.moveCount; k++)
                    {
                        
                    }


               

            }

            data_GameManager.moveCount--;

            isemptySlots = false;
        }


    }

    void DataMoving()
    {
        if (isInventoryMove == false)
        {

            GameObject Instance = Instantiate(myObject, transform.position, Quaternion.identity);
            GameObject instance1 = Instantiate(movingObject, transform.position, Quaternion.identity);

            Instance.transform.SetParent(InventorySlot[data_GameManager.moveCount].transform);
            Instance.transform.position = InventorySlot[data_GameManager.moveCount].transform.position;
            instance1.transform.SetParent(InventorySlot[data_GameManager.moveCount].transform);
            instance1.transform.position = InventorySlot[data_GameManager.moveCount].transform.position;

            Instance.GetComponent<DataSpace>().dataMoving = instance1;
            Instance.GetComponent<DataSpace>().dataMovingCount = false;
            instance1.GetComponent<WareHouseDataMove>().myObject = Instance;
            instance1.GetComponent<WareHouseDataMove>().isInventoryMove = true;


            /*myObject.SetActive(false);
            myObject.SetActive(true);*/








            data_GameManager.moveCount++;
        }

        else if (isInventoryMove == true)
        {
            Destroy(myObject);
            Destroy(movingObject);

            data_GameManager.moveCount--;
        }
        
    }
}
