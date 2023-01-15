using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Game
{
    public class Enemy : MonoBehaviour
    {

        public ObjectType enemyType;

        public int health = 100;
        public int attackPower = 10;

        public Transform player;
        public float attackRange = 5f;

        void Start()
        {
            player = GameObject.FindWithTag("Player").transform;
        }

        void Update()
        {
            RandomMovement();

            if (Vector3.Distance(transform.position, player.position) <= attackRange)
            {
                Attack();
            }
        }

        void RandomMovement()
        {
            // Randomly change the enemy's position
            transform.position = new Vector3(transform.position.x + Random.Range(-1f, 1f), transform.position.y, transform.position.z + Random.Range(-1f, 1f));
        }

        void Attack()
        {
            // Attack the player
            player.GetComponent<Player>().TakeDamage(attackPower);
        }

        public void TakeDamage(int damage)
        {
            health -= damage;
            if (health <= 0)
            {
                Die();
            }
        }

        void Die()
        {
            // Code for when the enemy dies
            Destroy(gameObject);
        }
    }
}
