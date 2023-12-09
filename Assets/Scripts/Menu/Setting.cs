using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Setting : MonoBehaviour
{
    public GameObject setting;
    public GameObject menu;
    
    public void OnMouseUp()
    {
        setting.SetActive(true);
        menu.SetActive(false);
    }
}
