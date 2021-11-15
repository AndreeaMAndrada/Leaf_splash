﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    private Inventory inventory;
    public GameObject itemButton;
    private void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();

    }
   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Player manager = collision.GetComponent<Player>();
        if (manager)
            for (int i = 0; i < inventory.slots.Length; i++)
            {
                if (inventory.isFull[i] == false)
                {
                    inventory.isFull[i] = true;
                    Instantiate(itemButton,inventory.slots[i].transform);
                    Destroy(gameObject);
                    break;
                }
            }
        {
            //manager.PickupItem(gameObject);
           
        }

    }
   
}
