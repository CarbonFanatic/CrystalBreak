using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameOverScore : MonoBehaviour
{
    public TextMeshProUGUI PointsUi;


    // Use this for initialization
    void Start()
    {
        PointsUi = GetComponent<TextMeshProUGUI>();

    }

    // Update is called once per frame
    void Update()
    {
        PointsUi.text = "Congratulations you have scored : " + GuiScreen.points;
    }



}