using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float timer;

    public GameObject compareActiveAnswer;

    private void Update()
    {
        timer += 1;

        if(timer>200)
        {
            compareActiveAnswer.GetComponent<CompareActiveAnswer>().ShowMakingIngredient.SetActive(false);
            compareActiveAnswer.GetComponent<CompareActiveAnswer>().block.SetActive(false);
            if (compareActiveAnswer.GetComponent<CompareActiveAnswer>().isInventoryOk == true)
            {
                compareActiveAnswer.GetComponent<CompareActiveAnswer>().keyboardinput.SetActive(true);
                compareActiveAnswer.GetComponent<CompareActiveAnswer>().isInventoryOk = false;
            }
        }
    }
}
