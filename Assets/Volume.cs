using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class Volume : MonoBehaviour
{
    
    public AudioMixer am;
    public bool volume = true;
    public GameObject on;
    public GameObject off;
    // Start is called before the first frame update
    void OnMouseUp()
    { 
        if(volume == true)
        {
            am.SetFloat("MyExposedParam", -80.0f);
            volume = false;
            on.SetActive(false);
            off.SetActive(true);
        }
        else if(volume == false) 
        {
            am.SetFloat("MyExposedParam", 0); 
            volume = true;
            on.SetActive(true);
            off.SetActive(false);
        }
    }
}
