using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CooldownUi : MonoBehaviour {
    public Text UiElement;

    // Use this for initialization
    void Start () {
        UiElement = GetComponent<Text>();

    }

    // Update is called once per frame
    void Update () {
        UiElement.text = Abilities.cooldownTimer.ToString();


    }
}
