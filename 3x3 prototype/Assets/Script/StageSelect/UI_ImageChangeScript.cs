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
        SettingImages();
        SettingPanel();
    }

    // Update is called once per frame
    void Update()
    {
        SettingImages();
        SettingPanel();
    }

    void SettingImages()
    {
        switch (stageNumber)
        {
            case 1:
                if (GameManager.instance.GetStage1Try() == false)
                {
                    this.gameObject.GetComponent<Image>().sprite = noneClearImage;
                }
                else
                {
                    if (GameManager.instance.GetStage1Clear() == true)
                    {
                        this.gameObject.GetComponent<Image>().sprite = firstClearImage;
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
                    }
                }
                break;
            case 2:
                if (GameManager.instance.GetStage2Try() == false)
                {
                    this.gameObject.GetComponent<Image>().sprite = noneClearImage;
                }
                else
                {
                    if (GameManager.instance.GetStage2Clear() == true)
                    {
                        this.gameObject.GetComponent<Image>().sprite = firstClearImage;
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
                    }
                }
                break;
            case 3:
                if (GameManager.instance.GetStage3Try() == false)
                {
                    this.gameObject.GetComponent<Image>().sprite = noneClearImage;
                }
                else
                {
                    if (GameManager.instance.GetStage3Clear() == true)
                    {
                        this.gameObject.GetComponent<Image>().sprite = firstClearImage;
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
                    }
                }
                break;
            default:
                break;
        }
    }
    void SettingPanel()
    {
        switch(stageNumber)
        {
            case 1:
                translucentLockPanel.SetActive(false);
                break;
            case 2:
                translucentLockPanel.SetActive(true);
                if (GameManager.instance.GetStage1Clear() == true || GameManager.instance.GetStage1HiddenClear() == true)
                    translucentLockPanel.SetActive(false);
                break;
            case 3:
                translucentLockPanel.SetActive(true);
                if (GameManager.instance.GetStage2Clear() == true || GameManager.instance.GetStage2HiddenClear() == true)
                    translucentLockPanel.SetActive(false);
                break;
        }
    }
}
