using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public static bool won;
    // Start is called before the first frame update
    void Start()
    {
        if (MainMenu.mode == 2)
        {
            if (Player.Score > 2000)
            {
                won = true;
            }
            else
            {
                won = false;
            }
        }
        else
        {
            if (Player.GameTime<6)
            {
                won = true;
            }
            else
            {
                won = false;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void MainMenuBut()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void Quitty()
    {
        Application.Quit();
    }
}
