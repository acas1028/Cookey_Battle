using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreEvaluationScript : MonoBehaviour
{
    public GameObject food;
    public GameObject effect;

    public Sprite foodImage_Bad;
    public Sprite foodImage_Good;
    public Sprite foodImage_Hidden;

    public Sprite effectImage_Bad;
    public Sprite effectImage_Good;
    public Sprite effectImage_Hidden;
    
    // Start is called before the first frame update
    void Start()
    {
        Evaluation();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Evaluation()
    {
        switch (GameManager.instance.GetStageLevel())
        {
            case 1:
                food.GetComponent<Image>().sprite = foodImage_Bad;
                effect.GetComponent<Image>().sprite = effectImage_Bad;
                if (GameManager.instance.GetStage1Clear())
                {
                    food.GetComponent<Image>().sprite = foodImage_Good;
                    effect.GetComponent<Image>().sprite = effectImage_Good;
                }
                if(GameManager.instance.GetStage1HiddenClear())
                {
                    food.GetComponent<Image>().sprite = foodImage_Hidden;
                    effect.GetComponent<Image>().sprite = effectImage_Hidden;
                }
                break;
            case 2:
                food.GetComponent<Image>().sprite = foodImage_Bad;
                effect.GetComponent<Image>().sprite = effectImage_Bad;
                if (GameManager.instance.GetStage2Clear())
                {
                    food.GetComponent<Image>().sprite = foodImage_Good;
                    effect.GetComponent<Image>().sprite = effectImage_Good;
                }
                if (GameManager.instance.GetStage2HiddenClear())
                {
                    food.GetComponent<Image>().sprite = foodImage_Hidden;
                    effect.GetComponent<Image>().sprite = effectImage_Hidden;
                }
                break;
            case 3:
                food.GetComponent<Image>().sprite = foodImage_Bad;
                effect.GetComponent<Image>().sprite = effectImage_Bad;
                if (GameManager.instance.GetStage3Clear())
                {
                    food.GetComponent<Image>().sprite = foodImage_Good;
                    effect.GetComponent<Image>().sprite = effectImage_Good;
                }
                if (GameManager.instance.GetStage3HiddenClear())
                {
                    food.GetComponent<Image>().sprite = foodImage_Hidden;
                    effect.GetComponent<Image>().sprite = effectImage_Hidden;
                }
                break;
        }
    }
}
