using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public static bool Shield = false;
    public float DmgReduct = 0;
    public float maxHealth = 100;
    public float currentHealth;
    public GameObject healthBarUI;
    public Slider slider;
    DateTime invincible = DateTime.Now;
    public float iframeTimer = 1;

    private void Start()
    {
        currentHealth = maxHealth;
        slider.value = CalculateHealth();
    }
    private void Update()
    {
        slider.value = CalculateHealth();
       
        // checks if player health is at 0 aka Dead.
        if (currentHealth <= 0)
        {
            SceneManager.LoadScene("GameOver");
            Destroy(gameObject);

        }
        // if for some reson current health is more the max health it sets current health to max health.
        if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }
    }

    public void TakeDamage(float amount)
    { 
        if (invincible <= DateTime.Now)
        {
            Reset();
            
            if (Shield == true)
            {
             // Multiplies the damage taken by a public variable allowing for reduced damage
                currentHealth -= (amount *(100- DmgReduct));
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
        invincible = DateTime.Now.AddSeconds(iframeTimer);
    }
    float CalculateHealth()
    {
        return currentHealth / maxHealth;
    }
    
}