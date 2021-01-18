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

    int enemy1Score;
    int enemy2Score;
    int playerScore;
    // Start is called before the first frame update
    void Start()
    {
        SetEnemyScore();

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
            this.gameObject.SetActive(false);
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
