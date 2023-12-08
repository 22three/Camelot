using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class PlaceTower : MonoBehaviour
{
    private GameManagerBehavior gameManager;
    public GameObject towerPrefab;
    private GameObject tower;
    private bool CanPlaceMonster()
    {
        int cost = towerPrefab.GetComponent<TowerData>().levels[0].cost;
        return tower == null && gameManager.Gold >= cost;
    }
    void OnMouseUp()
    {
        //2
        if (CanPlaceMonster())
        {
            tower = (GameObject)
                Instantiate(towerPrefab, transform.position, Quaternion.identity);
            //4
            AudioSource audioSource = gameObject.GetComponent<AudioSource>();
            audioSource.PlayOneShot(audioSource.clip);
            gameManager.Gold -= tower.GetComponent<TowerData>().CurrentLevel.cost;
        }
        else if (CanUpgradeTower())
        {
            tower.GetComponent<TowerData>().IncreaseLevel();
            AudioSource audioSource = gameObject.GetComponent<AudioSource>();
            audioSource.PlayOneShot(audioSource.clip);
            gameManager.Gold -= tower.GetComponent<TowerData>().CurrentLevel.cost;
        }
    }
    private bool CanUpgradeTower()
    {
        if (tower != null)
        {
            TowerData towerData = tower.GetComponent<TowerData>();
            TowerLevel nextLevel = towerData.GetNextLevel();
            if (nextLevel != null)
            {
                return gameManager.Gold >= nextLevel.cost;
            }
        }
        return false;
    }
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManagerBehavior>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
