using UnityEngine;
using System.Collections;

public class Abilities : MonoBehaviour {

	public GameObject shield;
    public float cooldown = 5;
    public static float cooldownTimer;
    private Rect timerRect = new Rect(20, 130, 50, 20);
    public Texture2D abilityIcon;

    void Start () {
    }

    void Update () {
        // Simple Cooldown timer for abilities
        if(cooldownTimer > 0)
        {
            cooldownTimer -= Time.deltaTime;
        }
        if (cooldownTimer < 0)
        {
            cooldownTimer = 0;
        }
        // if the cooldowntimer is 0 and Q is pressed spawns calls InvAura.
        if (Input.GetKeyDown(KeyCode.Q) && cooldownTimer == 0)
        {
            // sets cooldowntimer back to the cooldown.
            cooldownTimer = cooldown;
           
               InvAura();
            
        }
        }
    void OnGUI() {
        // used to place my abilitiy icon
        GUI.DrawTexture(new Rect(10, 90, abilityIcon.width, abilityIcon.height), abilityIcon);

        // Spawn a smal box with a float variable inside. 
        //"0.00" is used to format the float value to have 2 decimals.
        GUI.Box(timerRect, "" + cooldownTimer.ToString("0.00"));
    }


	void InvAura(){
        //instantiates a gameobject named shield.
		GameObject myShield = (GameObject)Instantiate (shield, transform.position, shield.transform.rotation);
        //gets its components from shield script.
		Shield shieldScript = myShield.GetComponent<Shield> ();
		shieldScript.myOwner = this.gameObject;
	}
}
