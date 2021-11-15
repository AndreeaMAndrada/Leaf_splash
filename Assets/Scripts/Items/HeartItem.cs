using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartItem : MonoBehaviour
{
    public static int HP = Player.HP;
    public static int HPp = 0;
    public static int X;
    private Inventory inventory;
    public static bool active = false;

    // Start is called before the first frame update
    void Start()
    {
       // Debug.Log("HPis" + HP);
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
    }

    // Update is called once per frame
    void Update()
    {
        HPp = Enemy.Hpc;
        
        X = HP;
        //  HPAdd();
        if (inventory.timeBtwUse <= 0)
        {
          if (Input.GetKeyDown(KeyCode.Q))
                {
                HPAdd();
                inventory.timeBtwUse = inventory.startTimeBtwUse;
            }
            
        }
        else
        {
            inventory.timeBtwUse -= Time.deltaTime;//setting time to decrease 
        }
    }
    public void HPAdd()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            
                HP = HPp + 10;
                Enemy.Hp = Enemy.Hp+10;
                InventoryManager.instance.AddHP(Enemy.Hp);
                Destroy(gameObject);
                Debug.Log("aaa" + Enemy.Hp);
                active = true;
                //X = HP;
            
        }
        active = false;
       

    }
    
}

