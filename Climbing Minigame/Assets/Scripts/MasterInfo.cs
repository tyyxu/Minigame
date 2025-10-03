using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MasterInfo : MonoBehaviour
{
    public static int points = 0;
    [SerializeField] GameObject pointsDisplay;

 void Update()
    {
        pointsDisplay.GetComponent<TMPro.TMP_Text>().text = "Points: " + points;
    }
}
