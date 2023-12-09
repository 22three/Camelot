using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fullscrean : MonoBehaviour
{
    public GameObject tuggle;
    // Start is called before the first frame update
    public void OnMouseUp()
    {
        if (Screen.fullScreen == true)
        {
            tuggle.SetActive(false);
            Screen.fullScreen = false;
        }
        else if(Screen.fullScreen == false)
        {
            tuggle.SetActive(true);
            Screen.fullScreen = true;
        }
       
    }
}
