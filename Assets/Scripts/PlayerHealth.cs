using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] float hitPoints = 100f;
    [SerializeField] TextMeshProUGUI healthText;

    void Update()
    {
        DisplayHealth();
    }

    private void DisplayHealth()
    {
      healthText.text = hitPoints.ToString(); 
    }

    public int GetCurrentAmmo()
    {
        return (int)hitPoints;
    }

    public void TakeDamage(float damage)
    {
        hitPoints -= damage;
        if (hitPoints <= 0)
        {
            GetComponent<DeathHandler>().HandleDeath();
        }
    }
}

