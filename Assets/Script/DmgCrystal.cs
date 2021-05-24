using UnityEngine;
using System.Collections;

public class DmgCrystal : MonoBehaviour
{
    public float dmg = 10;
    // Use this for initialization
    void OnTriggerEnter2D(Collider2D collider)
    {
   
        Destroy(this.gameObject);
        var hit = collider.gameObject;
        var health = hit.GetComponent<CrystalScript>();
        if (health != null)
        {
            health.currentHealth -= dmg;
        }
    }
}