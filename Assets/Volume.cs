using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Volume : MonoBehaviour
{
    
    public AudioMixer am;
    public GameObject on;
    public GameObject off;
    public Voice gameManager;
    
    void Start()
    {
        GameObject gm = GameObject.Find("GameManager");
        gameManager = gm.GetComponent<Voice>();
    }
    // Start is called before the first frame update
    void OnMouseUp()
    {
        if (gameManager.volume == true)
        {
            
            am.SetFloat("MyExposedParam", -80.0f);
            gameManager.volume = false;
            on.SetActive(false);
            off.SetActive(true);
        }
        else if (gameManager.volume == false)
        {
            am.SetFloat("MyExposedParam", 0);
            gameManager.volume = true;
            on.SetActive(true);
            off.SetActive(false);
        }
    }
}
