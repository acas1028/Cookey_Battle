using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlologueSkip : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject checkNameObject;
    void Start()
    {
        if (PlayerPrefs.HasKey("Name"))
            SceneManager.LoadScene(2);
            
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SkipTutorial()
    {
        checkNameObject.SetActive(true);
        this.gameObject.SetActive(false);
    }
}
