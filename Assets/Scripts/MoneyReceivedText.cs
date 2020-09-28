using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MoneyReceivedText : MonoBehaviour
{
    private TextMeshProUGUI MoneyReceivedTM;
    // Start is called before the first frame update
    void Start()
    {
        MoneyReceivedTM = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        MoneyReceivedTM.text = "Money Received from the driver: " + Player.MoneyReceived;
    }
}
