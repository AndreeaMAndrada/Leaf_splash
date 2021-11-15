using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedItem : MonoBehaviour
{
    public static float Speed = PlayerMovement.PlayerSpeed;
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
            if (Input.GetKeyDown(KeyCode.E))
            {
                SpeedAdd();
                inventory.timeBtwUse = inventory.startTimeBtwUse;
            }

        }
        else
        {
            inventory.timeBtwUse -= Time.deltaTime;//setting time to decrease 
        }
    }
    public void SpeedAdd()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Speed = Speed + 1;
            InventoryManager.instance.AddSpeed(Speed);
            Destroy(gameObject);
            
        }
    }
}
