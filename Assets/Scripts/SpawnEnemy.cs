using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Wave
{
    public GameObject[] enemyPrefab;
    public float spawnInterval = 2;
    public int maxEnemies = 20;
}
public class SpawnEnemy : MonoBehaviour
{
    public GameObject YouWinTitle;
    public GameObject ExitButton;
    public GameObject Boss;
    public Wave[] waves;
    public int timeBetweenWaves = 5;

    private GameManagerBehavior gameManager;

    private float lastSpawnTime;
    private int enemiesSpawned = 0;
    public GameObject[] waypoints;
    
    // Start is called before the first frame update
    void Start()
    {
        lastSpawnTime = Time.time;
        gameManager =
            GameObject.Find("GameManager").GetComponent<GameManagerBehavior>();
    }
    public int i = 0;
    // Update is called once per frame
    void Update()
    {
        
        // 1
        int currentWave = gameManager.Wave;
        if (currentWave < waves.Length)
        {
            // 2
            float timeInterval = Time.time - lastSpawnTime;
            float spawnInterval = waves[currentWave].spawnInterval;
            if (((enemiesSpawned == 0 && timeInterval > timeBetweenWaves) ||
                 timeInterval > spawnInterval) &&
                enemiesSpawned < waves[currentWave].maxEnemies)
            {
                if (waves[currentWave].enemyPrefab.Length > i)
                {
                    if (currentWave+1 == waves.Length)
                    {
                        Boss.SetActive(false);
                    }
                    lastSpawnTime = Time.time;
                    GameObject newEnemy = (GameObject)
                        Instantiate(waves[currentWave].enemyPrefab[i]);
                    newEnemy.GetComponent<MoveEnemy>().waypoints = waypoints;
                    enemiesSpawned++;
                    
                }
                else
                {
                    if (currentWave + 1 == waves.Length)
                    {
                        Boss.SetActive(false);
                    }
                    i = 0;
                    lastSpawnTime = Time.time;
                    GameObject newEnemy = (GameObject)
                        Instantiate(waves[currentWave].enemyPrefab[i]);
                    newEnemy.GetComponent<MoveEnemy>().waypoints = waypoints;
                    enemiesSpawned++;
                }
                i++;
            }
            // 4 
            if (enemiesSpawned == waves[currentWave].maxEnemies &&
                GameObject.FindGameObjectWithTag("Enemy") == null)
            {
                gameManager.Wave++;
                gameManager.Gold = Mathf.RoundToInt(gameManager.Gold * 1.1f);
                enemiesSpawned = 0;
                lastSpawnTime = Time.time;
            }
            // 5 
        }
        else
        {
            gameManager.gameOver = true;
            YouWinTitle.SetActive(true);
            ExitButton.SetActive(true);
        }
    }
}
