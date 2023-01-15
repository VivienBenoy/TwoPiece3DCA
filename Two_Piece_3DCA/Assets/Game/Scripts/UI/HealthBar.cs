using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public float maxHealth = 100;
    public Image healthbar;
    public float health;
    public Transform player;
    // Start is called before the first frame update
    void Start()
    {
        healthbar = GetComponent<Image>();
        player = GameObject.FindWithTag("Player").transform;
        health = player.GetComponent<Player>().getHealth();
    }

    // Update is called once per frame
    void Update()
    {
        healthbar.fillAmount = health / maxHealth;
    }
}
