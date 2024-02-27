using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class BulletBehavior : MonoBehaviour
{
    private GameManagerBehavior gameManager;
    private UpgrdDmg _upgradeDamage;
    [SerializeField] private float _speed;
    [SerializeField] int _damage;
    public GameObject target;
    public Vector3 startPosition;
    public Vector3 targetPosition;

    private float _distance;
    private float _startTime;
    
    // Start is called before the first frame update
    void Start()
    {
        _startTime = Time.time;
        _distance = Vector2.Distance(startPosition, targetPosition);
        GameObject gm = GameObject.Find("GameManager");
        gameManager = gm.GetComponent<GameManagerBehavior>();
    }

    // Update is called once per frame
    void Update()
    {
        int plusdmg = gameManager.BulletDMG;
        float timeInterval = Time.time - _startTime;
        gameObject.transform.position = Vector3.Lerp(startPosition, targetPosition, timeInterval * _speed / _distance);
        Vector3 direction = gameObject.transform.position - target.transform.position;
        gameObject.transform.rotation = Quaternion.AngleAxis(
            Mathf.Atan2(direction.y, direction.x) * 180 / Mathf.PI,
            new Vector3(0, 0, 1));
        
        // 2 
        if (gameObject.transform.position.Equals(targetPosition))
        {
            if (target != null)
            {
                // 3
                Transform healthBarTransform = target.transform.Find("HealthBar");
                HealthBar healthBar =
                    healthBarTransform.gameObject.GetComponent<HealthBar>();
                healthBar.currentHealth -= Mathf.Max(_damage, 0) + plusdmg;
                // 4
                if (healthBar.currentHealth <= 0)
                {
                    Destroy(target);
                    AudioSource audioSource = target.GetComponent<AudioSource>();
                    AudioSource.PlayClipAtPoint(audioSource.clip, transform.position);

                    gameManager.Gold += 50;
                }
            }
            Destroy(gameObject);
        }
    }
}
