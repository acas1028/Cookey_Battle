using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompareActiveAnswer : MonoBehaviour
{
    public GameObject fieldObject;
    public GameObject gameFinishObject;

    public GameObject compare_score;

    public GameObject movetag;

    public GameObject[] score_compare_basic_instance;

    public GameObject[] score_compare_instance;

    public GameObject maingame_inventory;

    public int score_compare_cal = 0;

    public Item_list item_List;

    public List<GameObject> basic_instance;

    public bool inventoryonoff = false;

    int ingameStage;
    int ingameStep;
    int hiddenConditionNumber;
    int hiddenCount;


    void Start()
    {
        ingameStage = GameManager.instance.GetStageLevel();
        ingameStep = 0;
        hiddenCount = 0;
        movetag.GetComponent<Find_tag>();

        //for(int i=0;i< score_compare_basic_instance.Length; i++)
        //{
        //    basic_instance.Add(score_compare_basic_instance[i]);
        //}


        switch (ingameStage)
        {
            case 1:
                hiddenConditionNumber = 3;
                break;
            case 2:
                hiddenConditionNumber = 4;
                break;
            case 3:
                hiddenConditionNumber = 5;
                break;
        }

    }

    // Update is called once per frame
    void Update()
    {
        if(movetag.GetComponent<WareHouseInventoryScript>().WareHouseDestroy == 1 && inventoryonoff==false)
        {
            score_compare_basic_instance = maingame_inventory.GetComponent<Inventory_clone_on>().inventory_clone;

            for (int i = 0; i < score_compare_basic_instance.Length; i++)
            {
                basic_instance.Add(score_compare_basic_instance[i]);
            }
            inventoryonoff = true;
        }
        switch (ingameStage)
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
                    for (int j = 0; j < score_compare_basic_instance.Length; j++)
                    {
                        
                        if (score_compare_basic_instance[j].GetComponent<DataMove>().space_onoff == true)
                        {
                            //Debug.Log("wwww");
                            for (int i = 0; i < score_compare_basic_instance.Length; i++)
                            {
                                if (score_compare_basic_instance[i].activeSelf == true)
                                {
                                    compare_score = score_compare_basic_instance[i];
                                    compare_score.GetComponent<DataMove>().Name_Compare();
                                    ingameStep++;
                                }
                            }
                        }
                    }

                    if (Input.GetKeyDown(KeyCode.F1))
                    {
                        ingameStep++;
                        hiddenCount++;
                    }
                }
                break;
            
            
            case 2:
                {
                    for (int j = 0; j < score_compare_basic_instance.Length; j++)
                    {
                        if (score_compare_basic_instance[j].GetComponent<DataMove>().space_onoff == true)
                        {
                            for (int i = 0; i < score_compare_basic_instance.Length; i++)
                            {
                                if (score_compare_basic_instance[i].activeSelf == true)
                                {
                                    compare_score = score_compare_basic_instance[i];
                                    compare_score.GetComponent<DataMove>().Name_Compare();
                                    ingameStep++;
                                }
                            }
                        }
                    }
                    if (Input.GetKeyDown(KeyCode.Alpha2))
                        ingameStep++;
                    else if (Input.GetKeyDown(KeyCode.F1))
                    {
                        ingameStep++;
                        hiddenCount++;
                    }
                }
                break;
            case 3:
                {
                    if (Input.GetKeyDown(KeyCode.Alpha3))
                        ingameStep++;
                    else if (Input.GetKeyDown(KeyCode.F1))
                    {
                        ingameStep++;
                        hiddenCount++;
                    }
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
                    }
                }
                break;

        }
    }

    void CompareAnswer_Stage2(int step)     // 13
    {
        switch (step)
        {
            case 1:
                {
                    if (Input.GetKeyDown(KeyCode.Alpha1))
                        ingameStep++;
                    else if (Input.GetKeyDown(KeyCode.F1))
                    {
                        ingameStep++;
                        hiddenCount++;
                    }
                }
                break;
            case 2:
                {
                    if (Input.GetKeyDown(KeyCode.Alpha2))
                        ingameStep++;
                    else if (Input.GetKeyDown(KeyCode.F1))
                    {
                        ingameStep++;
                        hiddenCount++;
                    }
                }
                break;
            case 3:
                {
                    if (Input.GetKeyDown(KeyCode.Alpha3))
                        ingameStep++;
                    else if (Input.GetKeyDown(KeyCode.F1))
                    {
                        ingameStep++;
                        hiddenCount++;
                    }
                }
                break;
            case 4:
                {
                    if (Input.GetKeyDown(KeyCode.Alpha4))
                        ingameStep++;
                    else if (Input.GetKeyDown(KeyCode.F1))
                    {
                        ingameStep++;
                        hiddenCount++;
                    }
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
                        ingameStep++;  
                }
                break;
            case 8:
                {
                    if (Input.GetKeyDown(KeyCode.Alpha8))
                        ingameStep++;
                }
                break;
            case 9:
                {
                    if (Input.GetKeyDown(KeyCode.Alpha9))
                        ingameStep++;
                }
                break;
            case 10:
                {
                    if (Input.GetKeyDown(KeyCode.Alpha0))
                        ingameStep++;
                }
                break;
            case 11:
                {
                    if (Input.GetKeyDown(KeyCode.Q))
                        ingameStep++;
                }
                break;
            case 12:
                {
                    if (Input.GetKeyDown(KeyCode.W))
                        ingameStep++;
                }
                break;
            case 13:
                if (Input.GetKeyDown(KeyCode.E))
                {
                    ingameStep++;

                    gameFinishObject.SetActive(true);
                }
                break;



        }
    }

    void CompareAnswer_Stage3(int step)     // 15
    {
        switch (step)
        {
            case 1:
                {
                    if (Input.GetKeyDown(KeyCode.Alpha1))
                        ingameStep++;
                    else if (Input.GetKeyDown(KeyCode.F1))
                    {
                        ingameStep++;
                        hiddenCount++;
                    }
                }
                break;
            case 2:
                {
                    if (Input.GetKeyDown(KeyCode.Alpha2))
                        ingameStep++;
                    else if (Input.GetKeyDown(KeyCode.F1))
                    {
                        ingameStep++;
                        hiddenCount++;
                    }
                }
                break;
            case 3:
                {
                    if (Input.GetKeyDown(KeyCode.Alpha3))
                        ingameStep++;
                    else if (Input.GetKeyDown(KeyCode.F1))
                    {
                        ingameStep++;
                        hiddenCount++;
                    }
                }
                break;
            case 4:
                {
                    if (Input.GetKeyDown(KeyCode.Alpha4))
                        ingameStep++;
                    else if (Input.GetKeyDown(KeyCode.F1))
                    {
                        ingameStep++;
                        hiddenCount++;
                    }
                }
                break;
            case 5:
                {
                    if (Input.GetKeyDown(KeyCode.Alpha5))
                        ingameStep++;
                    else if (Input.GetKeyDown(KeyCode.F1))
                    {
                        ingameStep++;
                        hiddenCount++;
                    }
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
                        ingameStep++;
                }
                break;
            case 8:
                {
                    if (Input.GetKeyDown(KeyCode.Alpha8))
                        ingameStep++;
                }
                break;
            case 9:
                {
                    if (Input.GetKeyDown(KeyCode.Alpha9))
                        ingameStep++;
                }
                break;
            case 10:
                {
                    if (Input.GetKeyDown(KeyCode.Alpha0))
                        ingameStep++;
                }
                break;
            case 11:
                {
                    if (Input.GetKeyDown(KeyCode.Q))
                        ingameStep++;
                }
                break;
            case 12:
                {
                    if (Input.GetKeyDown(KeyCode.W))
                        ingameStep++;
                }
                break;
            case 13:
                if (Input.GetKeyDown(KeyCode.E))
                {
                    ingameStep++;
                }
                break;
            case 14:
                if (Input.GetKeyDown(KeyCode.R))
                {
                    ingameStep++;
                }
                break;
            case 15:
                if (Input.GetKeyDown(KeyCode.T))
                {
                    ingameStep++;
                    gameFinishObject.SetActive(true);
                }

                break;



        }
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

    public int GetHiddenConditionNumber()
    {
        return hiddenConditionNumber;
    }

    public int GetHiddenCount()
    {
        return hiddenCount;
    }

}
