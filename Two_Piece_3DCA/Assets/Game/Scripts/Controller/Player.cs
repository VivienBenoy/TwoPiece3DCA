using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public GameObject player;
    public int health = 100;
    public int attackDamage = 20;
    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Die();
        }
    }
    public int getHealth()
    {
        return health;
    }
    public void Die()
    {
        GetComponent<PlayerController>().enabled = false;
        GetComponent<AnimaController>().enabled = false;

        
        GetComponent<Animator>().SetTrigger("Die");
        GetComponent<ParticleSystem>().Play();

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
}
