using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;


public class UpgrdDmg : MonoBehaviour
{
    // Start is called before the first frame update

    public TextMesh Gold;
    public TextMesh Cost;
    public TextMesh UpgrdSlot;
    private GameObject tower;
    private bool CanUpgrade()
    {
        int cost = int.Parse(Cost.text);
        int gold = int.Parse(Gold.text);
        return gold >= cost ? true : false;
    }
    public void OnMouseUp()
    {
        //2
        if (CanUpgrade())
        {
            int gold = int.Parse(Gold.text);
            int upgrdslot = int.Parse(UpgrdSlot.text) + 1;
            int cost = int.Parse(Cost.text);
            UpgrdSlot.text = $"{upgrdslot}";
            AudioSource audioSource = gameObject.GetComponent<AudioSource>();
            audioSource.PlayOneShot(audioSource.clip);
            gold -= cost;
            Gold.text = $"{gold}";
            int newcost = cost + 10;
            Cost.text = $"{newcost}";
        }
    }
}