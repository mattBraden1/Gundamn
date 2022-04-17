using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField]
    private float health = 100;
    private float currentHealth;
    private void Start()
    {
        currentHealth = health;
    }
    public void takeDamage(float damage)
    {
        if (damage <= currentHealth)
            currentHealth -= damage;
        else
            currentHealth = 0;
        if (currentHealth <= 0)
            Destroy(gameObject);
    }
    public float getMaxHealth()
    {
        return health;
    }
    public float getCurrentHealth()
    {
        return currentHealth;
    }
}
