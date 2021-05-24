using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GuiScreen : MonoBehaviour
{
    public static int points =0;
    public TextMeshProUGUI PointsUi;
     

        // Use this for initialization
        void Start()
    {
        PointsUi = GetComponent<TextMeshProUGUI>();

    }

    // Update is called once per frame
    void Update()
    {
        PointsUi.text = "Points : " + points;
    }



    }
