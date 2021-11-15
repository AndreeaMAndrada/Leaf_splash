using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    private bool appear;
    public GameObject inv;
    public bool[] isFull;
    public GameObject[] slots;
    public float timeBtwUse;//time between shots 
    public float startTimeBtwUse; 


    // Start is called before the first frame update
    void Start()
    {
        inv.SetActive(false);//start with the inv not active
        appear = false;
    }

    // Update is called once per frame
    void Update()
    {
        Updatekey();
    }

    private void Updatekey()
    {
        if (Input.GetKeyDown(KeyCode.I))//toggle this with another variable
        {
            if (appear == false)
            {
                inv.SetActive(true);//fucntion to set active an objectt
                appear = true;
            }
            else
            {
                inv.SetActive(false);
                appear = false;
            }

        }

    }
}
