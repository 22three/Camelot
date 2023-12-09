using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Loading : MonoBehaviour
{
    public GameObject loading0;
    public GameObject loading1;
    public GameObject loading2;
    public GameObject loading3;
    public int load = 0;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Loading1", 1);
    }
    void Loading0()
    {
        loading0.SetActive(true);
        loading1.SetActive(false);
        loading2.SetActive(false);
        loading3.SetActive(false);
        Invoke("Loading1", 1);
        load++;
        if (load == 20)
        {
            SceneManager.LoadScene("SampleScene");
        }
    }
    void Loading1()
    {
        loading0.SetActive(false);
        loading1.SetActive(true);
        loading2.SetActive(false);
        loading3.SetActive(false);
        Invoke("Loading2",1);
        load++;
        if (load == 20)
        {
            SceneManager.LoadScene("SampleScene");
        }
    }
    void Loading2()
    {
        loading0.SetActive(false);
        loading1.SetActive(false);
        loading2.SetActive(true);
        loading3.SetActive(false);
        Invoke("Loading3", 1);
        load++;
        if(load == 6)
        {
            SceneManager.LoadScene("SampleScene");
        }
    }
    void Loading3()
    {
        loading0.SetActive(false);
        loading1.SetActive(false);
        loading2.SetActive(false);
        loading3.SetActive(true);
        Invoke("Loading0", 1);
        load++;
        if (load == 6)
        {
            SceneManager.LoadScene("SampleScene");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
