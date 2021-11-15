using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static int HP =50;
    public double Speed;
    public int ATK = Projectile.damage;
    [SerializeField]
    public int HP2 = HeartItem.HP;
    public static int HP3 ;
    public static int Hpfe;
    public void Start()
    {
        //Debug.Log("player"+HP2);
    }
    public void Update()
    {
        HP2 = Enemy.Hp;
        HP3 = HeartItem.HPp;
        // Debug.Log("HP is  here" + HP2);
        //Debug.Log("Herec hahahahahahaha" + HP3);
        /*if (HeartItem.active)
        {
            Hp = HeartItem.HP;

        }*/
    }
    
       
    }
  
   

