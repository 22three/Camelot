using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerBehavior : MonoBehaviour
{
    [SerializeField] private GameObject GameOverTitle;
    [SerializeField] private GameObject Res;
    [SerializeField] private TextMesh waveLabel;
    [SerializeField] private GameObject nextWaveLabels;
    [SerializeField] private TextMesh goldLabel;
    [SerializeField] private TextMesh bulletDMG;
    [SerializeField] private TextMesh bulletSPD;
    [SerializeField] private TextMesh bulletRNG;
    private int DMG;
    private int SPD;
    private int RNG;
    private int gold;
    public bool gameOver = false;
    private int wave;
    [SerializeField] private TextMesh healthLabel;
    [SerializeField] private GameObject ScriptDeactivator;
    [SerializeField] private string scr;

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
    public int BulletDMG
    {
        get
        {
            return DMG;
        }
        set
        {
            DMG = value;
            bulletDMG.text = "" + DMG;
        }
    }
    public int BulletSPD
    {
        get
        {
            return SPD;
        }
        set
        {
            SPD = value;
            bulletSPD.text = "" + SPD;
        }
    }
    public int BulletRNG
    {
        get
        {
            return RNG;
        }
        set
        {
            RNG = value;
            bulletRNG.text = "" + RNG;
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
            health = value;
            healthLabel.text = "" + health;
            if (health <= 0 && !gameOver)
                GameOver();         
        }
    }

    void Start()
    {
        Health = 5;
        Wave = 0;
        Gold = 400;
        BulletDMG = 0;
        BulletSPD = 0;
        BulletRNG = 0;
    }

    void Deactiv()
    {
        nextWaveLabels.SetActive(false);
    }
    public void GameOver()
    {
        GameOverTitle.SetActive(true);
        Res.SetActive(true);
        gameOver = true;
        Time.timeScale = 0;
    }

    void Update()
    {

    }
}
