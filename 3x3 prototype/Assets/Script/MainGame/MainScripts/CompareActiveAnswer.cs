using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompareActiveAnswer : MonoBehaviour
{
    int ingameStage;
    int ingameStep;
    // Start is called before the first frame update
    void Start()
    {
        ingameStage = GameManager.instance.GetStageLevel();
        ingameStep = 0;
    }

    // Update is called once per frame
    void Update()
    {
        compareAnswer(ingameStep);
    }

    void compareAnswer(int step)
    {
        switch(step)
        {
            case 1:
                {
                    if (Input.GetKeyDown(KeyCode.Alpha1))
                        ingameStep++;
                }
                break;
            case 2:
                {
                    if (Input.GetKeyDown(KeyCode.Alpha2))
                        ingameStep++;
                }
                break;
            case 3:
                {
                    if (Input.GetKeyDown(KeyCode.Alpha3))
                        ingameStep++;
                }
                break;
            case 4:
                {
                    if (Input.GetKeyDown(KeyCode.Alpha4))
                        ingameStep++;
                }
                break;
            case 5:
                {
                    if (Input.GetKeyDown(KeyCode.Alpha5))
                        ingameStep++;
                }
                break;

        }
    }

    public int getingameStep()
    {
        return ingameStep;
    }

    public void setingameStep(int num)
    {
        ingameStep = num;
    }
}
