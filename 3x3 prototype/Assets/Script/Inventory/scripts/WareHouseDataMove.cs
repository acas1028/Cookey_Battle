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


    public bool isemptySlots = false;

    public int emptyslotCount = 0;

    public bool isInventoryMove = false;

    public float DoubleClick_Second = 0.25f;

    public bool OneClick = false;

    public double Timer = 0;






    void Start()
    {

        InventorySlot = GameObject.FindGameObjectsWithTag("Slot");

    }

    // Update is called once per frame
    void Update()
    {
        Timer = Time.time;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            DataMoving();
        }

        if (Input.GetMouseButtonDown(0))
        {
            if (!OneClick)
            {
                OneClick = true;
            }
            else if (OneClick && (Timer > DoubleClick_Second))
            {
                OneClick = false;
                DataMoving();
            }

            Debug.Log(Time.time - Timer);
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
                if (InventorySlot[i].transform.childCount == 0)
                {

                    for (int k = i + 1; k <= data_GameManager.moveCount; k++)
                    {
                        List<Transform> Children = new List<Transform>();

                        Children.Add(InventorySlot[k].transform.GetChild(0));
                        Children.Add(InventorySlot[k].transform.GetChild(1));
                        for (int t = 0; t < 2; t++)
                        {
                            Children[t].gameObject.transform.SetParent(InventorySlot[k - 1].transform);
                            Children[t].gameObject.transform.position = InventorySlot[k - 1].transform.position;
                        }




                    }
                }


            }



            isemptySlots = false;
        }




    }



    void DataMoving()
    {
        if (isInventoryMove == false && InventorySlot[31].transform.childCount == 0)
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
