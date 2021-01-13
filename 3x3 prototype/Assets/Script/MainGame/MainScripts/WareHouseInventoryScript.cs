using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WareHouseInventoryScript : MonoBehaviour
{
    public GameObject ingameStepObject;
    public GameObject MainKeyBoardInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            ingameStepObject.GetComponent<CompareActiveAnswer>().SetIngameStep(1);
            MainKeyBoardInput.SetActive(true);
            this.gameObject.SetActive(false);
        }
    }
}
