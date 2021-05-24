using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour {

    public float moveForce = 0f;
    private Rigidbody2D rbody;
    public Vector3 moveDir;
    public LayerMask whatIsWall;
    public float maxDistFromWall = 0f;
    public float DamageDone = 10;
    // Use this for initialization
    void Start() {
        rbody = GetComponent<Rigidbody2D>();
        moveDir = ChooseDir();
    }

    // Update is called once per frame
    void Update() {
        rbody.velocity = moveDir * moveForce;

        if (Physics.Raycast(transform.position, transform.forward, maxDistFromWall, whatIsWall))
        {
            moveDir = ChooseDir();
            transform.rotation = Quaternion.LookRotation(moveDir);
        }
    }
    Vector3 ChooseDir()
    {
        System.Random ran = new System.Random();
        int i = ran.Next(0, 1);
        Vector3 temp = new Vector3();

        if (i == 0)
        {
            temp = transform.right;
        }
        else if (i == 1)
        {
            temp = -transform.right;
        }

        return temp;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        var hit = collision.gameObject;
        var health = hit.GetComponent<PlayerHealth>();
      

       if (health != null)
        {
            health.TakeDamage(DamageDone);
        }


        else if (collision.gameObject.tag == "Wall")
        {
            moveDir = -moveDir;
            //Change direction on collision with environment
        }
        else if (collision.gameObject.tag == "Monster")
        {
            moveDir = -moveDir;
            //Change direction on collision with other enemies
        }
    }
}
