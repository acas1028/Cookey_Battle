using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_ImageChangeScript : MonoBehaviour
{
    public int stageNumber;
    public GameObject translucentLockPanel;
    public GameObject hiddenEffectPanel;
    public Sprite noneClearImage;
    public Sprite firstClearImage;
    public Sprite hiddenClearImage;
    public Sprite hiddenPerfectClearImage;

    public Sprite hiddenClearEffect;
    public Sprite hiddenPerfectClearEffect;
    // Start is called before the first frame update
    void Start()
    {
        switch(stageNumber)
        {
            case 1:
                if (GameManager.instance.GetStage1Clear() == false)
                {
                    this.gameObject.GetComponent<Image>().sprite = noneClearImage;
                    translucentLockPanel.SetActive(false);
                }
                else if (GameManager.instance.GetStage1Clear() == true)
                {
                    this.gameObject.GetComponent<Image>().sprite = firstClearImage;
                    translucentLockPanel.SetActive(false);
                }
                if(GameManager.instance.GetStage1HiddenClear() == true)
                {
                    hiddenEffectPanel.SetActive(true);
                    if (GameManager.instance.GetStage1Score() == 100)
                    {
                        this.gameObject.GetComponent<Image>().sprite = hiddenPerfectClearImage;
                        hiddenEffectPanel.GetComponent<Image>().sprite = hiddenPerfectClearEffect;
                    }
                    else
                    {
                        this.gameObject.GetComponent<Image>().sprite = hiddenClearImage;
                        hiddenEffectPanel.GetComponent<Image>().sprite = hiddenClearEffect;
                    }
                    translucentLockPanel.SetActive(false);
                }   
                break;
            case 2:
                if (GameManager.instance.GetStage2Clear() == false)
                {
                    this.gameObject.GetComponent<Image>().sprite = noneClearImage;
                    translucentLockPanel.SetActive(true);
                }
                else if (GameManager.instance.GetStage2Clear() == true)
                {
                    this.gameObject.GetComponent<Image>().sprite = firstClearImage;
                    translucentLockPanel.SetActive(false);
                }
                if (GameManager.instance.GetStage2HiddenClear() == true)
                {
                    hiddenEffectPanel.SetActive(true);
                    if (GameManager.instance.GetStage2Score() == 100)
                    {
                        this.gameObject.GetComponent<Image>().sprite = hiddenPerfectClearImage;
                        hiddenEffectPanel.GetComponent<Image>().sprite = hiddenPerfectClearEffect;
                    }
                    else
                    {
                        this.gameObject.GetComponent<Image>().sprite = hiddenClearImage;
                        hiddenEffectPanel.GetComponent<Image>().sprite = hiddenClearEffect;
                    }
                    translucentLockPanel.SetActive(false);
                }
                break;
            case 3:
                if (GameManager.instance.GetStage3Clear() == false)
                {
                    this.gameObject.GetComponent<Image>().sprite = noneClearImage;
                    translucentLockPanel.SetActive(true);
                }
                else if (GameManager.instance.GetStage3Clear() == true)
                {
                    this.gameObject.GetComponent<Image>().sprite = firstClearImage;
                    translucentLockPanel.SetActive(false);
                }
                if (GameManager.instance.GetStage3HiddenClear() == true)
                {
                    hiddenEffectPanel.SetActive(true);
                    if (GameManager.instance.GetStage3Score() == 100)
                    {
                        this.gameObject.GetComponent<Image>().sprite = hiddenPerfectClearImage;
                        hiddenEffectPanel.GetComponent<Image>().sprite = hiddenPerfectClearEffect;
                    }
                    else
                    {
                        this.gameObject.GetComponent<Image>().sprite = hiddenClearImage;
                        hiddenEffectPanel.GetComponent<Image>().sprite = hiddenClearEffect;
                    }
                    translucentLockPanel.SetActive(false);
                }
                break;
            default:
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        switch (stageNumber)
        {
            case 1:
                if (GameManager.instance.GetStage1Clear() == false)
                {
                    this.gameObject.GetComponent<Image>().sprite = noneClearImage;
                    translucentLockPanel.SetActive(false);
                }
                else if (GameManager.instance.GetStage1Clear() == true)
                {
                    this.gameObject.GetComponent<Image>().sprite = firstClearImage;
                    translucentLockPanel.SetActive(false);
                }
                if (GameManager.instance.GetStage1HiddenClear() == true)
                {
                    hiddenEffectPanel.SetActive(true);
                    if (GameManager.instance.GetStage1Score() == 100)
                    {
                        this.gameObject.GetComponent<Image>().sprite = hiddenPerfectClearImage;
                        hiddenEffectPanel.GetComponent<Image>().sprite = hiddenPerfectClearEffect;
                    }
                    else
                    {
                        this.gameObject.GetComponent<Image>().sprite = hiddenClearImage;
                        hiddenEffectPanel.GetComponent<Image>().sprite = hiddenClearEffect;
                    }
                    translucentLockPanel.SetActive(false);
                }
                break;
            case 2:
                if (GameManager.instance.GetStage2Clear() == false)
                {
                    this.gameObject.GetComponent<Image>().sprite = noneClearImage;
                    translucentLockPanel.SetActive(true);
                }
                else if (GameManager.instance.GetStage2Clear() == true)
                {
                    this.gameObject.GetComponent<Image>().sprite = firstClearImage;
                    translucentLockPanel.SetActive(false);
                }
                if (GameManager.instance.GetStage2HiddenClear() == true)
                {
                    hiddenEffectPanel.SetActive(true);
                    if (GameManager.instance.GetStage2Score() == 100)
                    {
                        this.gameObject.GetComponent<Image>().sprite = hiddenPerfectClearImage;
                        hiddenEffectPanel.GetComponent<Image>().sprite = hiddenPerfectClearEffect;
                    }
                    else
                    {
                        this.gameObject.GetComponent<Image>().sprite = hiddenClearImage;
                        hiddenEffectPanel.GetComponent<Image>().sprite = hiddenClearEffect;
                    }
                    translucentLockPanel.SetActive(false);
                }
                break;
            case 3:
                if (GameManager.instance.GetStage3Clear() == false)
                {
                    this.gameObject.GetComponent<Image>().sprite = noneClearImage;
                    translucentLockPanel.SetActive(true);
                }
                else if (GameManager.instance.GetStage3Clear() == true)
                {
                    this.gameObject.GetComponent<Image>().sprite = firstClearImage;
                    translucentLockPanel.SetActive(false);
                }
                if (GameManager.instance.GetStage3HiddenClear() == true)
                {
                    hiddenEffectPanel.SetActive(true);
                    if (GameManager.instance.GetStage3Score() == 100)
                    {
                        this.gameObject.GetComponent<Image>().sprite = hiddenPerfectClearImage;
                        hiddenEffectPanel.GetComponent<Image>().sprite = hiddenPerfectClearEffect;
                    }
                    else
                    {
                        this.gameObject.GetComponent<Image>().sprite = hiddenClearImage;
                        hiddenEffectPanel.GetComponent<Image>().sprite = hiddenClearEffect;
                    }
                    translucentLockPanel.SetActive(false);
                }
                break;
            default:
                break;
        }
    }

}
