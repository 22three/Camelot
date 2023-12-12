using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeRNG : MonoBehaviour
{
    // Start is called before the first frame update
    public GameManagerBehavior gameManager;
    public TextMesh Gold;
    public TextMesh Cost;
    //public TextMesh bulletDMG;
    public int RNG;
    void Start()
    {
        GameObject gm = GameObject.Find("GameManager");
        gameManager = gm.GetComponent<GameManagerBehavior>();
    }
    private bool CanUpgrade()
    {
        int cost = int.Parse(Cost.text);
        int gold = int.Parse(Gold.text);
        return gold >= cost ? true : false;
    }
    //public int BulletDMG
    //{
    //    get
    //    {
    //        return DMG;
    //    }
    //    set
    //    {
    //        DMG = value;
    //        bulletDMG.text = "" + DMG;
    //    }
    //}
    public void OnMouseUp()
    {
        //2
        if (CanUpgrade())
        {
            int cost = int.Parse(Cost.text);

            //AudioSource audioSource = gameObject.GetComponent<AudioSource>();
            //audioSource.PlayOneShot(audioSource.clip);
            gameManager.BulletRNG += 1;
            gameManager.Gold -= cost;
            int newcost = cost + 10;
            Cost.text = $"{newcost}";
        }
    }
}
