using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField]
    private float health = 100;
    private float currentHealth;
    [SerializeField]
    public float iFrame = 100;
    private float currentIFrame;
    private void Start()
    {
        currentHealth = health;
        currentIFrame = -100;
    }
    private void Update()
    {
        if (currentIFrame < iFrame)
            currentIFrame += .1f;
        else if (currentIFrame > iFrame)
            currentIFrame = iFrame;
    }
    public void takeDamage(float damage)
    {
        if (currentIFrame == iFrame)
        {
            if (damage <= currentHealth)
                currentHealth -= damage;
            else
                currentHealth = 0;
            currentIFrame = 0;
        }
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
