﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    // 세팅
    private static GameManager Instance;
    private string userName;      // 이름 저장
    public float musicVol = 0.5f; // 음악 소리
    public float soundVol = 0.5f; // 효과음 소리

    // 세팅
    // ======================================================================
    // 진행상황(스테이지)
    private bool stage1Try; // 시도했는가?
    private bool stage2Try;
    private bool stage3Try;
    private bool stage1Clear;  // 스테이지1 클리어 판별변수
    private bool stage1HiddenClear; // 스테이지1 히든클리어 판별변수   이하 동문
    private bool stage2Clear;
    private bool stage2HiddenClear;
    private bool stage3Clear;
    private bool stage3HiddenClear;
    // 진행상황(스테이지)
    // ========================================================================
    private int ingameStage; //스테이지 입장 시 어떤 스테이지인지 판별하게해주는 변수
    private int stage1Score; //스테이지1 최종 점수
    private int stage2Score; //스테이지2 최종 점수
    private int stage3Score; //스테이지3 최종 점수
    // ========================================================================
    private int stage1HighScore; // 최고점
    private int stage2HighScore;
    private int stage3HighScore;


    public static GameManager instance
    {
        get
        {
            if(Instance == null)
            {
                var obj = FindObjectOfType<GameManager>();
                if(obj != null)
                {
                    Instance = obj;
                }
                else
                {
                    var newSingleton = new GameObject("GameManager").AddComponent<GameManager>();
                    Instance = newSingleton;
                }
            }
            return Instance;
        }
        private set
        {
            Instance = value;
        }
    }

    void Awake()
    {
        var objs = FindObjectsOfType<GameManager>();
        if(objs.Length!= 1)
        {
            Destroy(gameObject);
            return;
        }
        userName = "";

        stage1Try = false;
        stage2Try = false;
        stage3Try = false;
        stage1Clear = false;
        stage2Clear = false;
        stage3Clear = false;
        stage1HiddenClear = false;
        stage2HiddenClear = false;
        stage3HiddenClear = false;
        DontDestroyOnLoad(gameObject);
    }
    void Start()
    {
        if(PlayerPrefs.HasKey("Name"))
        {
            userName = PlayerPrefs.GetString("Name");
        }

        if(PlayerPrefs.HasKey("Stage1"))
        {
            switch(PlayerPrefs.GetInt("Stage1"))
            {
                case 0:
                    break;
                case 1:
                    stage1Clear = true;
                    break;
                case 2:
                    stage1HiddenClear = true;
                    break;
            }
        }

        if (PlayerPrefs.HasKey("Stage2"))
        {
            switch (PlayerPrefs.GetInt("Stage2"))
            {
                case 0:
                    break;
                case 1:
                    stage2Clear = true;
                    break;
                case 2:
                    stage2HiddenClear = true;
                    break;
            }
           
        }

        if (PlayerPrefs.HasKey("Stage3"))
        {
            switch (PlayerPrefs.GetInt("Stage3"))
            {
                case 0:
                    break;
                case 1:
                    stage3Clear = true;
                    break;
                case 2:
                    stage3HiddenClear = true;
                    break;
            }
        }

        if(PlayerPrefs.HasKey("Stage1Score"))
        {
            stage1Score = PlayerPrefs.GetInt("Stage1Score");
            stage1Try = true;  // 점수가있다 => 시도를 했다.
        }
        if (PlayerPrefs.HasKey("Stage2Score"))
        {
            stage2Score = PlayerPrefs.GetInt("Stage2Score");
            stage2Try = true;
        }
        if (PlayerPrefs.HasKey("Stage3Score"))
        {
            stage3Score = PlayerPrefs.GetInt("Stage3Score");
            stage3Try = true;
        }



    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void SetUserName(string pUserName)
    {
        userName = pUserName;
    }

    public string GetUserName()
    {
        return userName;
    }

    public int GetStageLevel()
    {
        return ingameStage;
    }

    public void SetStageLevel(int stageLevel)
    {
        ingameStage = stageLevel;
    }

    public bool GetStage1Clear()
    {
        return stage1Clear;
    }

    public bool GetStage2Clear()
    {
        return stage2Clear;
    }

    public bool GetStage3Clear()
    {
        return stage3Clear;
    }

    public bool GetStage1HiddenClear()
    {
        return stage1HiddenClear;
    }

    public bool GetStage2HiddenClear()
    {
        return stage2HiddenClear;
    }

    public bool GetStage3HiddenClear()
    {
        return stage3HiddenClear;
    }

    public void SetStage1Clear(bool isClear)
    {
        stage1Clear = isClear;
    }
    public void SetStage2Clear(bool isClear)
    {
        stage2Clear = isClear;
    }
    public void SetStage3Clear(bool isClear)
    {
        stage3Clear = isClear;
    }

    public void SetStage1HiddenClear(bool isClear)
    {
        stage1HiddenClear = isClear;
    }
    public void SetStage2HiddenClear(bool isClear)
    {
        stage2HiddenClear = isClear;
    }
    public void SetStage3HiddenClear(bool isClear)
    {
        stage3HiddenClear = isClear;
    }

    public void SetStage1Score(int Score)
    {
        stage1Score = Score;
    }

    public void SetStage2Score(int Score)
    {
        stage2Score = Score;
    }

    public void SetStage3Score(int Score)
    {
        stage3Score = Score;
    }

    public int GetStage1Score()
    {
        return stage1Score;
    }

    public int GetStage2Score()
    {
        return stage2Score;
    }

    public int GetStage3Score()
    {
        return stage3Score;
    }

    public bool GetStage1Try()
    {
        return stage1Try;
    }

    public bool GetStage2Try()
    {
        return stage2Try;
    }

    public bool GetStage3Try()
    {
        return stage3Try;
    }

    public void SetStage1Try(bool isTry)
    {
        stage1Try = isTry;
    }
    public void SetStage2Try(bool isTry)
    {
        stage2Try = isTry;
    }
    public void SetStage3Try(bool isTry)
    {
        stage3Try = isTry;
    }

    public void ResetGameManager()
    {
        userName = "";

        stage1Clear = false;
        stage2Clear = false;
        stage3Clear = false;
        stage1HiddenClear = false;
        stage2HiddenClear = false;
        stage3HiddenClear = false;
        stage1Try = false;
        stage2Try = false;
        stage3Try = false;
        stage1Score = 0;
        stage2Score = 0;
        stage3Score = 0;
    }
}
