using UnityEngine;
using System.Collections;

public class DamageScript : MonoBehaviour
{
    public int damage = 10;
    void OnCollisionEnter2D(Collision2D collision)
    {
        var hit = collision.gameObject;
        var health = hit.GetComponent<EnemyHealth>();
        if (health != null)
        {
            health.currentHealth -= damage;
        }
        if (collision.gameObject.tag != "Player")
        {
            Destroy(gameObject);
        }
    }
}