using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitInLVL : MonoBehaviour
{
    public GameObject PauseMenu;
    void OnMouseUp()
    {
        PauseMenu.SetActive(false);
        Time.timeScale = 1;
        SceneManager.LoadScene("Menu");
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
