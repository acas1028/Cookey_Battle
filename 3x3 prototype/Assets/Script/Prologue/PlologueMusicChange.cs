using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlologueMusicChange : MonoBehaviour
{
    GameObject BackgroundMusic;
    public AudioClip backMusic;
    // Start is called before the first frame update
    void Start()
    {
        BackgroundMusic = GameObject.Find("MusicBox");
        BackgroundMusic.GetComponent<AudioSource>().clip = backMusic;
        BackgroundMusic.GetComponent<AudioSource>().Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
