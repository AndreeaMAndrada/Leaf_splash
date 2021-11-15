using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed;
    public float lifeTime;
    public float distance;
    public LayerMask whatIsSolid;
    public GameObject destroyEffect;
    public static int damage;//it is in the projectile part
   public  static int damageup = 5;
    int damagep = ATKItem.Atk;

    //Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("DestroyProjectile", lifeTime);
       // rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit2D hitInfo = Physics2D.Raycast(transform.position, transform.up, distance, whatIsSolid);// the original position, where is going, what the distance is and what to hit with
        if (hitInfo.collider != null) //if it hids a colider 
        {
            if (hitInfo.collider.CompareTag("Boost"))
            {
                damageup = damageup + damagep;
                Debug.Log("damagep"+damagep);
                //InventoryManager.instance.AddDamage(damageup);
                //Debug.Log("booost" + damageup);
                hitInfo.collider.GetComponent<Enemy>().TakeDamage(damageup);
                DestroyProjectile();//destroy the projectile function

            }

            if (hitInfo.collider.CompareTag("Enemy")) //if it hits the enemy colider
            {
                damageup =  damagep;
                Debug.Log("damagep" + damagep);
                Debug.Log("DIE!" + damageup);//how to write in the logs
                hitInfo.collider.GetComponent<Enemy>().TakeDamage(damageup);//the hitinfo when it colides gets the components from the enemy class from the function take damage

            }

            if (hitInfo.collider.CompareTag("Ground"))
            {
                DestroyProjectile();//destroy the projectile function
            }
                DestroyProjectile();//destroy the projectile function
        }

        transform.Translate(Vector2.up * speed * Time.deltaTime);//puts the speend on the projectile

       
    }
    void DestroyProjectile()
    {
         destroyEffect = Instantiate(destroyEffect, transform.position, Quaternion.identity);//the effect is made out of the effect, position and identity
         Destroy(destroyEffect, 0.5f);//is destroyed after 0,5f
        
        Destroy(gameObject);

    }
}
