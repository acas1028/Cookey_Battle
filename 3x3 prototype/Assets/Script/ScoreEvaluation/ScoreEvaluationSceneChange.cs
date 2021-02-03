using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreEvaluationSceneChange : MonoBehaviour
{

    public int goToBadEnding;
    public int goToStageSelect;
    bool isClear;
    // Start is called before the first frame update
    void Start()
    {
        isClear = false;
        switch(GameManager.instance.GetStageLevel())
        {
            case 1:
                if (GameManager.instance.GetStage1Clear())
                    isClear = true;
                else
                    isClear = false;
                break;
            case 2:
                if (GameManager.instance.GetStage2Clear())
                    isClear = true;
                else
                    isClear = false;
                break;
            case 3:
                if (GameManager.instance.GetStage3Clear())
                    isClear = true;
                else
                    isClear = false;
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void sceneChange()
    {
        if (isClear == true)
            LoadingSceneManager.LoadScene(goToStageSelect);
        else
            LoadingSceneManager.LoadScene(goToBadEnding);
    }
}
