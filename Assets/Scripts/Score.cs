using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{

    private TextMeshProUGUI ScoreTM;
    // Start is called before the first frame update
    void Start()
    {
        ScoreTM = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        ScoreTM.text = "Score : " + Player.Score;
    }
}
