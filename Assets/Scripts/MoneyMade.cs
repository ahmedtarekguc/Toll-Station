using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MoneyMade : MonoBehaviour
{
    private TextMeshProUGUI MoneyMadeTM;
    // Start is called before the first frame update
    void Start()
    {
        MoneyMadeTM = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        MoneyMadeTM.text = "Total money made: " + Player.MoneyMade;
    }
}
