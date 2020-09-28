using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ProblemOutput : MonoBehaviour
{
    private TextMeshProUGUI ProblemTM;
    // Start is called before the first frame update
    void Start()
    {
        ProblemTM = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        ProblemTM.text = Player.problemOutput;
    }
}
