using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WonOrlost : MonoBehaviour
{
    private TextMeshProUGUI TotalInHandTM;
    int timesecint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        timesecint = (int)Player.GameTimeSec;
        TotalInHandTM = GetComponent<TextMeshProUGUI>();
        if (MainMenu.mode != 0)
        {
            if (GameOver.won == true)
            {
                if (MainMenu.mode == 1)
                {
                    TotalInHandTM.text = "Congratulations you won. Your score is " + Player.Score + " and your time is " + Player.GameTime.ToString("00") + ":" + timesecint.ToString("00");
                }
                else
                {
                    TotalInHandTM.text = "Congratulations you won. Your score is " + Player.Score;
                }
            }
            else
            {
                if (MainMenu.mode == 1)
                {
                    TotalInHandTM.text = "You lost. Good luck in the next game. Your score is " + Player.Score + " and your time is " + Player.GameTime.ToString("00") + ":" + timesecint.ToString("00");
                }
                else
                {
                    TotalInHandTM.text = "You lost. Good luck in the next game. Your score is " + Player.Score;
                }
            }
        }
        else
        {
            TotalInHandTM.text = "Good game. Your score is " + Player.Score + " and your time is " + Player.GameTime.ToString("00") + ":" + timesecint.ToString("00");
        }

    }
}
