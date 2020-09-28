using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TotalInDrawer : MonoBehaviour
{
    private TextMeshProUGUI TotalInDrawerTM;
    // Start is called before the first frame update
    void Start()
    {
        TotalInDrawerTM = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        TotalInDrawerTM.text = "Total in drawer: " + Player.TotalInDrawer;
    }
}
