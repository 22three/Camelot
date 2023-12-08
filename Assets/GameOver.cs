using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject ScriptDeactivator;
    public string scr;
    public void OnMouseUp()
    {
        (ScriptDeactivator.GetComponent(scr) as MonoBehaviour).enabled = true;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
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
