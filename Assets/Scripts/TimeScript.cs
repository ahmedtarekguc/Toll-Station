using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimeScript : MonoBehaviour
{
    private TextMeshProUGUI TimeTM;
    // Start is called before the first frame update
    void Start()
    {
        TimeTM = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        TimeTM.text = "Time: " + Player.GameTime.ToString("00") + " : " + Player.timeAfterInt.ToString("00");
    }
}
