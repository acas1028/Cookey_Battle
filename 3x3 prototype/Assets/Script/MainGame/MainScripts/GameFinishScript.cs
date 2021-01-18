using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameFinishScript : MonoBehaviour
{
   
    // Start is called before the first frame update
    void Start()
    {
        
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
                    GameManager.instance.SetStage1Score(65);
                    break;
                case 2:
                    GameManager.instance.SetStage2Try(true);
                    break;
                case 3:
                    GameManager.instance.SetStage3Try(true);
                    break;
                default:
                    break;
            }
            LoadingSceneManager.LoadScene(8);
        }
    }
}
