using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ATKItem : MonoBehaviour
{
    public static int Atk = Projectile.damageup;
    private Inventory inventory;

    // Start is called before the first frame update
    void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (inventory.timeBtwUse <= 0)
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                ATKAdd();
                inventory.timeBtwUse = inventory.startTimeBtwUse;
            }

        }
        else
        {
            inventory.timeBtwUse -= Time.deltaTime;//setting time to decrease 
        }
    }
    public void ATKAdd()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {   
            Atk = Atk + 5;
            InventoryManager.instance.AddDamage(Atk);
            Destroy(gameObject);
        }
    }
}
