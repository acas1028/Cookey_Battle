using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WareHouseScript : MonoBehaviour
{
    public GameObject ingamestepObject;
    public GameObject panel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            this.gameObject.SetActive(false);
            panel.gameObject.SetActive(false);
            startCooking();
        }
    }

    void startCooking()
    {
        ingamestepObject.GetComponent<CompareActiveAnswer>().setingameStep(1);
    }
}
