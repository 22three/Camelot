using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Start : MonoBehaviour
{
    // Start is called before the first frame update
    void OnMouseUp()
    {
        Debug.Log("Lalala");
        SceneManager.LoadScene("SampleScene");
    }

}
