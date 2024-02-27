using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Start : MonoBehaviour
{
    // Start is called before the first frame update
    void OnMouseUp()
    {
        SceneManager.LoadScene("Guide");
        
    }
}
