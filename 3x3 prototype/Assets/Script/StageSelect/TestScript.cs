using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
            GameManager.instance.SetStage1Clear(true);
        if (Input.GetKeyDown(KeyCode.W))
            GameManager.instance.SetStage2Clear(true);
        if (Input.GetKeyDown(KeyCode.E))
            GameManager.instance.SetStage3Clear(true);
        if (Input.GetKeyDown(KeyCode.A))
            GameManager.instance.SetStage1HiddenClear(true);
        if (Input.GetKeyDown(KeyCode.S))
            GameManager.instance.SetStage2HiddenClear(true);
        if (Input.GetKeyDown(KeyCode.D))
            GameManager.instance.SetStage3HiddenClear(true);
    }
}
