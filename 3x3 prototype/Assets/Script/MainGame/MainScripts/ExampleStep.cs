using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExampleStep : MonoBehaviour
{
    public GameObject Object;
    public Text text;
    int count;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        count = Object.GetComponent<CompareActiveAnswer>().getingameStep();
        text.text = "단계:" + count;
    }
}
