using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health;//Health
    public int dmgdealt;
    public static int dmgd;
    public float atkspeed = 1f;
    private float canAttack;
    public static int Hp;
    public static int Hpc;
    private Player player;
    public static bool activeenemy = false;
    // private float timeBtwHit = 0;
    // private float startTimeBtwHit = 3;
    // Start is called before the first frame update
    void Start()
    {
       //Hp = HeartItem.HP;

        
        dmgd = dmgdealt;
        if (HeartItem.active == true)
        {
            Hp = Player.HP;
        }
        else
        {
            Hp = HeartItem.HP;

        }
        Debug.Log("Enemy" + Hp);

    }

    // Update is called once per frame
    void Update()
    {
        

        
       // Debug.Log("Kaka" + Hp);
        //Debug.Log("Enemy" + Hp + HeartItem.active);
        if (health <= 0 && CompareTag("Boost"))
        {
            Destroy(gameObject);
            //ScoreManager.instance.AddPoint();//adds in stance of the score keeper 
        }
        if (health <= 0)
        {
            Destroy(gameObject);
        }
                   


    }
    private void OnCollisionStay2D(Collision2D other)
    {
        

        if (other.gameObject.tag == "Player")
        {
            if (atkspeed <= canAttack)
            {
                // player.DmgDown(dmgdealt);
                Hp = Hp - dmgdealt;
                InventoryManager.instance.AddHP(Hp);
                Debug.Log("You have" + Hp);//thisi is the HP the Player Has

                Hpc = Hp;
                canAttack = 0f;
                activeenemy = true;
            }
            else
            {
                canAttack += Time.deltaTime;
               
            }
            activeenemy = false;

        }
       
    }
    public void TakeDamage(int damage)//from projectile class it gets the info from there
    {
        health -= damage; //substract dmg from health

    }
    public void DealDamage(int dmg)
    {

    }
}
