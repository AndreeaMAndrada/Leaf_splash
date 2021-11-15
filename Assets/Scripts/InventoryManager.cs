using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{
    public static InventoryManager instance;
    public Text HP;
    public Text ATK;
    public Text SPEED;
    int HPs = 50;
    int damage = 5;
    public double speed = PlayerMovement.sped;
    // Start is called before the first frame update
    private void Awake()
    {
        instance = this; //instanciate the Score Manager
    }
    void Start()
    {
        HP.text = HPs.ToString() + " HP";
        ATK.text = damage.ToString() + " ATK";
        SPEED.text = speed.ToString() + " SPEED";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AddDamage(int damageup)
    {
        damage = damageup;
        ATK.text = damage.ToString() + " ATK";

    }
    public void AddSpeed(double speedup)
    {
        speed = speedup;
        SPEED.text = speed.ToString() + "SPEED";
    }
    public void AddHP(int hpup)
    {
        HPs = hpup;
        HP.text = HPs.ToString() + " HP";
    }
    

}
