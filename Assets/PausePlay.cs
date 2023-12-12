using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PausePlay : MonoBehaviour
{
    public GameObject PauseMenu;
    void OnMouseUp()
    {
        Time.timeScale = 1;
        PauseMenu.SetActive(false);
    }
}
        // Update is called once per fram