using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompareActiveAnswer : MonoBehaviour
{
    public GameObject fieldObject;
    public GameObject gameFinishObject;

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
        switch(ingameStage)
        {
            case 1:
                CompareAnswer_Stage1(ingameStep);
                break;
            case 2:
                CompareAnswer_Stage2(ingameStep);
                break;
            case 3:
                CompareAnswer_Stage3(ingameStep);
                break;
        }
    }

    void CompareAnswer_Stage1(int step)  // 예를들어 스텝 7이 끝
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
            case 6:
                {
                    if (Input.GetKeyDown(KeyCode.Alpha6))
                        ingameStep++;
                }
                break;
            case 7:
                {
                    if (Input.GetKeyDown(KeyCode.Alpha7))
                    {
                        ingameStep++;

                        gameFinishObject.SetActive(true);
                        // GameManager.instance.SetStage1Score(fieldObject.GetComponent<FieldObjectScript>().getFieldScore());
                    }
                }
                break;

        }
    }

    void CompareAnswer_Stage2(int step)     // 13
    {

    }

    void CompareAnswer_Stage3(int step)     // 15
    {

    }
    public int GetIngameStep()
    {
        return ingameStep;
    }

    public int GetIngameStage()
    {
        return ingameStage;
    }
    public void SetIngameStep(int num)
    {
        ingameStep = num;
    }
}
