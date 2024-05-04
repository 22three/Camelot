using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootEnemies : MonoBehaviour
{
    private float _lastShotTime;
    private TowerData _towerData;
    public List<GameObject> _enemiesInRange;
    private GameManagerBehavior _gameManagerBehavior;
    private CircleCollider2D _circleCollider;

    void OnEnemyDestroy(GameObject enemy)
    {
        _enemiesInRange.Remove(enemy);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag.Equals("Enemy"))
        {
            _enemiesInRange.Add(other.gameObject);
            EnemyDestructionDelegate del =
                other.gameObject.GetComponent<EnemyDestructionDelegate>();
            del.enemyDelegate += OnEnemyDestroy;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag.Equals("Enemy"))
        {
            _enemiesInRange.Remove(other.gameObject);
            EnemyDestructionDelegate del =
                other.gameObject.GetComponent<EnemyDestructionDelegate>();
            del.enemyDelegate -= OnEnemyDestroy;
        }
    }

    void Start()
    {
        GameObject gameManager = GameObject.Find("GameManager");
        _gameManagerBehavior = gameManager.GetComponent<GameManagerBehavior>();
        _enemiesInRange = new List<GameObject>();
        _lastShotTime = Time.time;
        _towerData = gameObject.GetComponentInChildren<TowerData>();
    }
    void Shoot(Collider2D target)
    {
        GameObject bulletPrefab = _towerData.CurrentLevel.bullet;

        Vector3 startPosition = gameObject.transform.position;
        Vector3 targetPosition = target.transform.position;
        startPosition.z = bulletPrefab.transform.position.z;
        targetPosition.z = bulletPrefab.transform.position.z;

        GameObject newBullet = (GameObject)Instantiate(bulletPrefab);
        newBullet.transform.position = startPosition;
        BulletBehavior bulletComponent = newBullet.GetComponent<BulletBehavior>();
        bulletComponent.target = target.gameObject;
        bulletComponent.startPosition = startPosition;
        bulletComponent.targetPosition = targetPosition;

        AudioSource audioSource = gameObject.GetComponent<AudioSource>();
        audioSource.PlayOneShot(audioSource.clip);
    }

    void Update()
    {
        _circleCollider = GetComponent<CircleCollider2D>();
        _circleCollider.radius = _circleCollider.radius + (_gameManagerBehavior.BulletRNG * 0.001f);
        GameObject target = null;

        float minimalEnemyDistance = float.MaxValue;
        foreach (GameObject enemy in _enemiesInRange)
        {
            float distanceToGoal = enemy.GetComponent<MoveEnemy>().DistanceToGoal();
            if (distanceToGoal < minimalEnemyDistance)
            {
                target = enemy;
                minimalEnemyDistance = distanceToGoal;
            }
        }

        if (target != null)
        {
            if (Time.time - _lastShotTime > _towerData.CurrentLevel.fireRate - (_gameManagerBehavior.BulletSPD*0.01))
            {
                Shoot(target.GetComponent<Collider2D>());
                _lastShotTime = Time.time;
            }
        }
    }
}
