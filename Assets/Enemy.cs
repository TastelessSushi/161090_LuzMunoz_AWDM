using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health = 30; //Enemy health

    public GameObject deathEffect;

    public void IsDamaged(int Damage) //Allows to take damage
    {
        health -= Damage;

        if (health <= 0)
        {
            Death();
        }
    }

    void Death()
    {
        Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
