using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Back : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject setting;
    public GameObject menu;

    public void OnMouseUp()
    {
        setting.SetActive(false);
        menu.SetActive(true);
    }

}
