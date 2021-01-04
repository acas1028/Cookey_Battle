using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    private static GameManager Instance;
    private string userName;
    public float musicVol = 0.5f;
    public float soundVol = 0.5f;
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
        DontDestroyOnLoad(gameObject);
    }
    void Start()
    {
        if(PlayerPrefs.HasKey("Name"))
        {
            userName = PlayerPrefs.GetString("Name");
        }
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void setUserName(string pUserName)
    {
        userName = pUserName;
    }

    public string getUserName()
    {
        return userName;
    }
}
