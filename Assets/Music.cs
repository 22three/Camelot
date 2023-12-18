using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class Music : MonoBehaviour
{
    // Start is called before the first frame update
    public Voice gameManager;
    public AudioMixer am;
    
    public GameObject on;
    public GameObject off;
    void Start()
    {
        GameObject gm = GameObject.Find("GameManager");
        gameManager = gm.GetComponent<Voice>();
    }
    // Start is called before the first frame update
    void OnMouseUp()
    {
        if (gameManager.musicvolume == true)
        {
            am.SetFloat("Music", -80.0f);
            gameManager.musicvolume = false;
            on.SetActive(false);
            off.SetActive(true);
        }
        else if (gameManager.musicvolume == false )
        {
            am.SetFloat("Music", 0);
            gameManager.musicvolume = true;
            on.SetActive(true);
            off.SetActive(false);
        }
        
    }
    
}
