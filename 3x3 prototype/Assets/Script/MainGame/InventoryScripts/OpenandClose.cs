using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenandClose : MonoBehaviour
{
    public GameObject inventoryPanel;
    public bool activeInventory = false;

    private void Start()
    {
        inventoryPanel.SetActive(activeInventory);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            activeInventory = !activeInventory;
            inventoryPanel.SetActive(activeInventory);
        }
        else if (activeInventory == true)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                activeInventory = !activeInventory;
                inventoryPanel.SetActive(activeInventory);
            }
        }

    }
}
