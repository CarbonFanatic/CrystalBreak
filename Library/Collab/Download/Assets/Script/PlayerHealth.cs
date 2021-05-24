using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public bool Shield = true;
    public float DmgReduct = 0;
    public float maxHealth = 100;
    public float currentHealth;
    public GameObject healthBarUI;
    public Slider slider;


    private void Start()
    {
        currentHealth = maxHealth;
        slider.value = CalculateHealth();
    }
    private void Update()
    {
        slider.value = CalculateHealth();

        if (currentHealth < maxHealth)
        {
            healthBarUI.SetActive(true);
        }
        if (currentHealth <= 0)
        {
            Destroy(gameObject);
        }
        if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }
    }
    DateTime invincible = DateTime.Now;

    public void TakeDamage(float amount)
    {
        if (invincible <= DateTime.Now)
        {
            Reset();

            if (Shield == true)
            {
                currentHealth -= (amount * DmgReduct);
            }
            else
                currentHealth -= amount;
            if (currentHealth < 0)
                currentHealth = 0;
            slider.value = CalculateHealth();

        }
    }

    void Reset()
    {
        
        invincible = DateTime.Now.AddSeconds(1);
    }
    float CalculateHealth()
    {
        return currentHealth / maxHealth;
    }
}