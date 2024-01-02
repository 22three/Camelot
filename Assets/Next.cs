using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class Next : MonoBehaviour
{
    public GameObject Nextt;
    public GameObject Play;
    public GameObject List1;
    public GameObject List2;

    // Start is called before the first frame update
    void OnMouseUp()
    {
        Nextt.SetActive(false); Play.SetActive(true); List1.SetActive(false); List2.SetActive(true);
    }
}
