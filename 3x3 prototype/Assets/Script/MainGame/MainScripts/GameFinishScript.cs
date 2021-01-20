using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameFinishScript : MonoBehaviour
{
    public GameObject ingameStepObject;
    public GameObject fieldObject;

    int hiddenCondition;
    int hiddenCount;

    int fieldScore;
    // Start is called before the first frame update
    void Start()
    {
        hiddenCondition = ingameStepObject.GetComponent<CompareActiveAnswer>().GetHiddenConditionNumber();
        hiddenCount = ingameStepObject.GetComponent<CompareActiveAnswer>().GetHiddenCount();

        fieldScore = fieldObject.GetComponent<FieldObjectScript>().GetFieldScore();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            switch(GameManager.instance.GetStageLevel())
            {
                case 1:
                    GameManager.instance.SetStage1Try(true);
                    Stage1_ClearCheck();
                    LoadingSceneManager.LoadScene(8);
                    break;
                case 2:
                    GameManager.instance.SetStage2Try(true);
                    Stage2_ClearCheck();
                    LoadingSceneManager.LoadScene(9);
                    break;
                case 3:
                    GameManager.instance.SetStage3Try(true);
                    Stage3_ClearCheck();
                    LoadingSceneManager.LoadScene(10);
                    break;
            }
            
        }
    }
    
    void Stage1_ClearCheck()
    {
        PlayerPrefs.SetInt("Stage1", 0);
        GameManager.instance.SetStage1State(0);
        if (fieldScore >= 60)
        {
            GameManager.instance.SetStage1Clear(true);
            GameManager.instance.SetStage1HiddenClear(false);
            PlayerPrefs.SetInt("Stage1", 1);
            GameManager.instance.SetStage1State(1);
            if (hiddenCondition == hiddenCount)
            {
                GameManager.instance.SetStage1HiddenClear(true);
                PlayerPrefs.SetInt("Stage1", 2);
                GameManager.instance.SetStage1State(2);
            }

            GameManager.instance.SetStageProgress(1);
        }
        else
            GameManager.instance.SetStageProgress(0);

        GameManager.instance.SetStage1Score(fieldScore);

        if(fieldScore > GameManager.instance.GetStage1HighScore())
        {
            GameManager.instance.SetStage1HighScore(fieldScore);
            PlayerPrefs.SetInt("Stage1HighScore", fieldScore);
        }

    }

    void Stage2_ClearCheck()
    {
        PlayerPrefs.SetInt("Stage2", 0);
        GameManager.instance.SetStage2State(0);
        if (fieldScore >= 80)
        {
            GameManager.instance.SetStage2Clear(true);
            GameManager.instance.SetStage2HiddenClear(false);
            PlayerPrefs.SetInt("Stage2", 1);
            GameManager.instance.SetStage2State(1);
            if (hiddenCondition == hiddenCount)
            {
                GameManager.instance.SetStage2HiddenClear(true);
                PlayerPrefs.SetInt("Stage1", 2);
                GameManager.instance.SetStage2State(2);
            }
            GameManager.instance.SetStageProgress(2);
        }
        else
            GameManager.instance.SetStageProgress(0);
        GameManager.instance.SetStage2Score(fieldScore);

        if (fieldScore > GameManager.instance.GetStage2HighScore())
        {
            GameManager.instance.SetStage2HighScore(fieldScore);
            PlayerPrefs.SetInt("Stage2HighScore", fieldScore);
        }
    }

    void Stage3_ClearCheck()
    {
        PlayerPrefs.SetInt("Stage3", 0);
        GameManager.instance.SetStage3State(0);
        if (fieldScore >= 90)
        {
            GameManager.instance.SetStage3Clear(true);
            PlayerPrefs.SetInt("Stage3", 1);
            GameManager.instance.SetStage3State(1);
            if (hiddenCondition == hiddenCount)
            {
                GameManager.instance.SetStage1HiddenClear(true);
                PlayerPrefs.SetInt("Stage3", 2);
                GameManager.instance.SetStage3State(2);
            }
            GameManager.instance.SetStageProgress(3);
        }
        else
            GameManager.instance.SetStageProgress(0);
        GameManager.instance.SetStage3Score(fieldScore);

        if (fieldScore > GameManager.instance.GetStage3HighScore())
        {
            GameManager.instance.SetStage3HighScore(fieldScore);
            PlayerPrefs.SetInt("Stage3HighScore", fieldScore);
        }
    }
}
