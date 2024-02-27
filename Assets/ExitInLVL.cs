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
}
