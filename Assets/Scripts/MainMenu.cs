using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class MainMenu : MonoBehaviour
{
    public static int mode;

    public GameObject MainMenucanvas;
    public GameObject OptionsCanvas;
    public GameObject CreditsCanvas;
    public GameObject HowToPlaycanvas;
    public GameObject ChooseGameModeCanvas;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        ChooseGameModeCanvas.SetActive(false);
        CreditsCanvas.SetActive(false);
        MainMenucanvas.SetActive(true);
        OptionsCanvas.SetActive(false);
        HowToPlaycanvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void HowToPlay()
    {
        ChooseGameModeCanvas.SetActive(false);
        CreditsCanvas.SetActive(false);
        MainMenucanvas.SetActive(false);
        OptionsCanvas.SetActive(false);
        HowToPlaycanvas.SetActive(true);
    }

    public void Quitty()
    {
        Application.Quit();
    }

    public void NewGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void Credits()
    {
        ChooseGameModeCanvas.SetActive(false);
        CreditsCanvas.SetActive(true);
        MainMenucanvas.SetActive(false);
        OptionsCanvas.SetActive(false);
        HowToPlaycanvas.SetActive(false);
    }

    public void Options()
    {
        ChooseGameModeCanvas.SetActive(false);
        CreditsCanvas.SetActive(false);
        MainMenucanvas.SetActive(false);
        OptionsCanvas.SetActive(true);
        HowToPlaycanvas.SetActive(false);
    }

    public void Back()
    {
        ChooseGameModeCanvas.SetActive(false);
        CreditsCanvas.SetActive(false);
        MainMenucanvas.SetActive(true);
        OptionsCanvas.SetActive(false);
        HowToPlaycanvas.SetActive(false);
    }

    public void ChooseMode()
    {
        ChooseGameModeCanvas.SetActive(true);
        CreditsCanvas.SetActive(false);
        MainMenucanvas.SetActive(false);
        OptionsCanvas.SetActive(false);
        HowToPlaycanvas.SetActive(false);
    }

    //Time is 0 and score is number and when number is completed, game is over
    public void BeatTheTime()
    {
        mode = 1;
        SceneManager.LoadScene("Game");
    }

    //Time will be set to number and score to a number when time is 0 game is over
    public void BeatTheScore()
    {
        mode = 2;
        SceneManager.LoadScene("Game");
    }

    public void FreePlay()
    {
        mode = 0;
        SceneManager.LoadScene("Game");
    }

}
