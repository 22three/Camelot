using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Voice : MonoBehaviour
{
    public bool VLM;
    public bool MVLM;
    public bool volume
    {
        get
        {
            return VLM;
        }
        set
        {
            VLM = value;
        }
    }
    public bool musicvolume
    {
        get
        {
            return MVLM;
        }
        set
        {
            MVLM = value;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        volume = true;
        MVLM = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
