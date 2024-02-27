using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Volume : MonoBehaviour
{
    
    [SerializeField]private AudioMixer audioMixer;
    [SerializeField]private GameObject onButton;
    [SerializeField]private GameObject offButton;
    [SerializeField]private Voice sound;
    
    void Start()
    {
        GameObject gameManager = GameObject.Find("GameManager");
        sound = gameManager.GetComponent<Voice>();
    }
    
    void OnMouseUp()
    {
        SpeakVolume(!sound.volume);         
    }

    void SpeakVolume(bool status) 
    {
        float value = status == false ? - 80.0f : 0;
        audioMixer.SetFloat("MyExposedParam", value);
        sound.volume = status;
        onButton.SetActive(status);
        offButton.SetActive(!status);
    }

}
