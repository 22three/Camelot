using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerBehavior : MonoBehaviour
{
    public GameObject GameOverTitle;
    public GameObject RestartButton;
    public GameObject ExitButton;
    public TextMesh waveLabel;
    public GameObject nextWaveLabels;
    public TextMesh goldLabel;
    private int gold;
    public bool gameOver = false;
    private int wave;
    public TextMesh healthLabel;
    public GameObject ScriptDeactivator;
    public string scr;
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

                if (wave != 0)
                {
                    nextWaveLabels.SetActive(true);
                    Invoke("Deactiv", 3);
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
            goldLabel.text = "" + gold;
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
                GameOver();
                
                //myObj.SetActive(true);

                
                //GameObject gameOverText = GameObject.FindGameObjectWithTag("GameOver");
                //gameOverText.GetComponent<Animator>().SetBool("gameOver", true);
            }
            // 4 
            
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        Health = 5;
        Wave = 0;
        Gold = 270;
    }

    void Deactiv()
    {
        nextWaveLabels.SetActive(false);
    }
    public void GameOver()
    {
        GameOverTitle.SetActive(true);
        RestartButton.SetActive(true);
        ExitButton.SetActive(true);
        gameOver = true;
        (ScriptDeactivator.GetComponent(scr) as MonoBehaviour).enabled = false;
    }
    // Update is called once per frame
    void Update()
    {

    }
}
