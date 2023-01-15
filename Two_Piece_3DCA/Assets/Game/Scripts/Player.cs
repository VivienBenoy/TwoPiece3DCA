using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int health = 100;
    public int attackPower = 20;
    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Die();
        }
    }
    public void Attack()
    {

    }

    void Die()
    {
       
        GetComponent<PlayerController>().enabled = false;
        GetComponent<AnimaController>().enabled = false;

        // Play death animation or effect
        GetComponent<Animator>().SetTrigger("Die");
        GetComponent<ParticleSystem>().Play();

        
    }
}
