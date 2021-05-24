using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class PlayerShoot : NetworkBehaviour {

    public GameObject PrefabBullet;
    public Transform ShootSpawn;
    

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            Shoot();
        }
    }

    void Shoot()
    {

        // Spawn Group at current Position
        var bullets = (GameObject)Instantiate(PrefabBullet,
                     ShootSpawn.position,
                      ShootSpawn.rotation);

            bullets.GetComponent<Rigidbody2D>().velocity = bullets.transform.right * 6;
            Destroy(bullets, 3.0f);
    }

}
