using UnityEngine;
using System.Collections;

public class Shield : MonoBehaviour {

	public GameObject myOwner;
	public float duration;
	float timer;

	void Start () {
		timer = duration;
	}

	void Update () {
		timer -= Time.deltaTime;

		transform.position = myOwner.transform.position;
        // when timer is 0 set the shield boolean in player health to false
		if (timer <= 0) {
			Death();
            PlayerHealth.Shield = false;
		}
        // Set Shield boolean to true
        else if(timer >0)
        {
            PlayerHealth.Shield = true;
        }
        

	}
    //When called, destroys the gameObject
	public void Death(){
		Destroy(gameObject);
	}
}
