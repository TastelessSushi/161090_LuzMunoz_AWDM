using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{

    public float speed = 20f;
    public int damage = 6;
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Enemy enemy_a = hitInfo.GetComponent<Enemy>();
        if (enemy_a != null)
        {
            enemy_a.IsDamaged(damage);
        }
        //Destroy(gameObject);
    }
}
