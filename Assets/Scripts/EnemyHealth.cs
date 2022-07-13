using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
   [SerializeField] float hitpoints = 100f;

   // create a public method which reduces hit points by the amount of dmg
   public void TakeDamage (float damage)
   {
        BroadcastMessage("OnDamageTaken");
        hitpoints -= damage;
        if (hitpoints <= 0)
        {
            Destroy(gameObject);
        }
        else {
            return;
        }
   }
}
