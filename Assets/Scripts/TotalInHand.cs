using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TotalInHand : MonoBehaviour
{
    private TextMeshProUGUI TotalInHandTM;
    // Start is called before the first frame update
    void Start()
    {
        TotalInHandTM = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        TotalInHandTM.text = "Total in hand: " + Player.TotalInHand;
    }
}
