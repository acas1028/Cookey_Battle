using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataSpace : MonoBehaviour
{
    public Data_GameManager data_GameManager;

    public GameObject dataMoving;

    public int count;

    public Item_list item_List;

    public bool dataMovingCount = false;

    public WareHouseInventoryScript wareHouseInventoryScript;

    

    private void Update()
    {
        for (int i = 0; i < data_GameManager.warehouseItemList.Count; i++)
        {
            if (count == i)
            {
                item_List = data_GameManager.warehouseItemList[i];
            }
        }
        

        if(dataMovingCount==true)
        {
            dataMoving.SetActive(true);
        }
        if(dataMovingCount==false)
        {
            dataMoving.SetActive(false);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Cursor" )
        {
            dataMovingCount = true;
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Cursor" )
        {
            dataMovingCount = false;
        }   
    }


}
