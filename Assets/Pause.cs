using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    private bool gameonpause = false;
    public GameObject PauseMenu;
    void OnMouseUp()
    {

        if (gameonpause == false)
        {
            Time.timeScale = 0;
            gameonpause = true;
            PauseMenu.SetActive(true);
        }
        else
        {
            Time.timeScale = 1;
            gameonpause = false;
            PauseMenu.SetActive(false);
        }
        
    }
        // Start is called before the first frame update
        void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
