using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManagerBehavior : MonoBehaviour
{
    public Text waveLabel;
    public GameObject[] nextWaveLabels;
    public Text goldLabel;
    private int gold;
    public bool gameOver = false;
    private int wave;
    public Text healthLabel;
    public int Wave
    {
        get
        {
            return wave;
        }
        set
        {
            wave = value;
            if (!gameOver)
            {
                for (int i = 0; i < nextWaveLabels.Length; i++)
                {
                    //nextWaveLabels[i].GetComponent<Animator>().SetTrigger("nextWave");
                }
            }
            waveLabel.text = "" + (wave + 1);
        }
    }
    public int Gold
    {
        get
        {
            return gold;
        }
        set
        {
            gold = value;
            goldLabel.GetComponent<Text>().text = "" + gold;
        }
    }
    private int health;
    public int Health
    {
        get
        {
            return health;
        }
        set
        {
            // 1
            
            // 2
            health = value;
            healthLabel.text = "" + health;
            // 3
            if (health <= 0 && !gameOver)
            {
                gameOver = true;
                GameObject.FindGameObjectWithTag("GameOver").SetActive(true);
                //gameOverText.SetActive(true);
            }
            // 4 
            
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        Health = 5;
        Wave = 0;
        Gold = 1000;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
