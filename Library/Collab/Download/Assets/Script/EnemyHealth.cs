using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour
{
    public int pointsInc = 1;
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
            GuiScreen.points += pointsInc;

            Destroy(gameObject);
        }
        if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }
    }
    public void TakeDamage(float amount)
    {
        currentHealth -= amount;
        if (currentHealth < 0)
            currentHealth = 0;
        slider.value = CalculateHealth();

    }


    float CalculateHealth()
    {
        return currentHealth / maxHealth;
    }
}