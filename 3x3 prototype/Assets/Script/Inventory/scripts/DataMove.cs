using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataMove : MonoBehaviour
{
    public GameObject parents;

    public Data_GameManager data_GameManager;

    public GameObject myObject;

    public GameObject movingObject;

   

    

    
    void Start()
    {
        
        
        
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
        
            myObject.transform.SetParent(parents.transform);
            myObject.transform.position = parents.transform.position;
        movingObject.transform.SetParent(parents.transform);
        movingObject.transform.position = parents.transform.position;
        

        
        
    }
}
