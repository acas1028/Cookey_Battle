using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BeforeChangeScript : MonoBehaviour
{
    public GameObject afterSpaceObject_1st;
    public GameObject afterSpaceObject_2nd;
    public GameObject afterSpaceObject_3rd;
    public GameObject foodCover;
    public GameObject backGroundEffect;

    public GameObject goMainMenuButton;
    public GameObject goStageSelectButton;


    public Sprite goodEffect;
    public Sprite badEffect;
    public Sprite hiddenEffect;

    int enemy1Score;
    int enemy2Score;
    int playerScore;
    // Start is called before the first frame update
    void Start()
    {
        SetEnemyScore();
        SetEffect();

        Debug.Log("player" + playerScore);
        Debug.Log("enemy1" + enemy1Score);
        Debug.Log("enemy2" + enemy2Score);

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if (playerScore >= enemy1Score && playerScore >= enemy2Score)
                afterSpaceObject_1st.SetActive(true);
            else if (playerScore >= enemy1Score && playerScore < enemy2Score)
                afterSpaceObject_2nd.SetActive(true);
            else if (playerScore >= enemy2Score && playerScore < enemy1Score)
                afterSpaceObject_2nd.SetActive(true);
            else if (playerScore < enemy1Score && playerScore < enemy2Score)
                afterSpaceObject_3rd.SetActive(true);

            foodCover.SetActive(false);
            backGroundEffect.SetActive(true);
            this.gameObject.SetActive(false);
            goMainMenuButton.SetActive(true);
            goStageSelectButton.SetActive(true);
        }
    }

    void SetEnemyScore()
    {
        switch(GameManager.instance.GetStageLevel())
        {
            case 1:
                enemy1Score = Random.Range(45, 59);
                enemy2Score = Random.Range(45, 59);
                playerScore = GameManager.instance.GetStage1Score();
                break;
            case 2:
                enemy1Score = Random.Range(70, 79);
                enemy2Score = Random.Range(70, 79);
                playerScore = GameManager.instance.GetStage2Score();
                break;
            case 3:
                enemy1Score = Random.Range(85, 89);
                enemy2Score = Random.Range(85, 89);
                playerScore = GameManager.instance.GetStage3Score();
                break;
        }
       
    }

    void SetEffect()
    {
        switch(GameManager.instance.GetStageLevel())
        {
            case 1:
                backGroundEffect.GetComponent<Image>().sprite = badEffect;
                if (GameManager.instance.GetStage1Clear())
                    backGroundEffect.GetComponent<Image>().sprite = goodEffect;
                if (GameManager.instance.GetStage1HiddenClear())
                    backGroundEffect.GetComponent<Image>().sprite = hiddenEffect;
                break;
            case 2:
                backGroundEffect.GetComponent<Image>().sprite = badEffect;
                if (GameManager.instance.GetStage2Clear())
                    backGroundEffect.GetComponent<Image>().sprite = goodEffect;
                if (GameManager.instance.GetStage2HiddenClear())
                    backGroundEffect.GetComponent<Image>().sprite = hiddenEffect;
                break;
            case 3:
                backGroundEffect.GetComponent<Image>().sprite = badEffect;
                if (GameManager.instance.GetStage3Clear())
                    backGroundEffect.GetComponent<Image>().sprite = goodEffect;
                if (GameManager.instance.GetStage3HiddenClear())
                    backGroundEffect.GetComponent<Image>().sprite = hiddenEffect;
                break;
        }
    }
    public int GetEnemy1Score()
    {
        return enemy1Score;
    }

    public int GetEnemy2Score()
    {
        return enemy2Score;
    }
    public int GetPlayerScore()
    {
        return playerScore;
    }

}
