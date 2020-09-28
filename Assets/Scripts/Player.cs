using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Player : MonoBehaviour
{
    public GameObject car;
    public GameObject bus;

    public GameObject ticket;
    public GameObject Money;

    public GameObject Settingscanvas;
    public GameObject PausedCanvas;
    public GameObject GameCanvas;
    GameObject BusClone;
    GameObject CarClone;
    public GameObject AreYouSureCanvas;
    public Canvas laptopcanvas;
    
    public static int InHand10 = 0;
    public static int InHand20 = 0;
    public static int InHand50 = 0;
    public static int InHand100 = 0;
    public static int InHand200 = 0;

    public static int InDrawer10 = 5;
    public static int InDrawer20 = 5;
    public static int InDrawer50 = 2;
    public static int InDrawer100 = 1;
    public static int InDrawer200 = 0;

    public static int availableTicket = 0;
    public static int Score;
    public static int NoOfCars = 1;

    public static int MoneyMade = 0;
    public static int TotalInHand = 0;
    public static int TotalInDrawer = 0;
    public static int MoneyToBeMade = 0;
    public static int MoneyReceived = 0;

    double Timer = 3f;
    double TextTimer = 3f;

    public static bool given = false;
    public static bool printTicketStarted = false;
    public static bool arrived = true;

    bool paused = false;
    bool DecTime = false;
    
    public Material TenLe;
    public Material TwentyLe;
    public Material FiftyLe;
    public Material HundredLe;
    public Material TwoHundredLe;

    public static int GameTime;
    public static float GameTimeSec;

    public static string problemOutput = "";

    public Camera camera1;
    
    public static int timeAfterInt;

    // Start is called before the first frame update
    void Start()
    {
        InHand10 = 0;
        InHand20 = 0;
        InHand50 = 0;
        InHand100 = 0;
        InHand200 = 0;

        InDrawer10 = 5;
        InDrawer20 = 5;
        InDrawer50 = 2;
        InDrawer100 = 1;
        InDrawer200 = 0;

        availableTicket = 0;
        Score = 0;
        NoOfCars = 1;

        MoneyMade = 0;
        TotalInHand = 0;
        TotalInDrawer = 0;

        Timer = 3f;
        TextTimer = 3f;



        if (MainMenu.mode == 1 || MainMenu.mode == 0)
        {
            GameTime = 0;
            GameTimeSec = 0;
        }
        else
        {
            GameTime = 6;
            GameTimeSec = 0;
        }

        paused = false;
        Time.timeScale = 1;
        GameCanvas.SetActive(true);
        PausedCanvas.SetActive(false);
        Settingscanvas.SetActive(false);
        laptopcanvas.enabled = true;
        AreYouSureCanvas.SetActive(false);

        int RandomNum = Random.Range(1, 3);
        if (RandomNum == 1)
        {
            CarClone = Instantiate(car, new Vector3(-5.7f, 1.1f, 20f), transform.rotation) as GameObject;
        }
        else
        {
            BusClone = Instantiate(bus, new Vector3(-7.48f, -0.34f, 20f), transform.rotation) as GameObject;
        }
        
        printTicketStarted = false;
    }

    // Update is called once per frame
    void Update()
    {
        timeAfterInt = (int)GameTimeSec;

        if (MainMenu.mode == 2)
        {
            if (GameTimeSec > 0)
            {
                GameTimeSec -= Time.deltaTime;
            }
            else
            {
                if (GameTimeSec <= 0)
                {
                    if (GameTime == 0)
                    {
                        GameOver();
                    }
                    else
                    {
                        GameTime -= 1;
                        GameTimeSec = 59;
                    }
                }
            }
        }
        else
        {
            if (MainMenu.mode == 1)
            {
                if (Score > 2000)
                {
                    SceneManager.LoadScene("GameOver");
                }
            }
            if (GameTimeSec < 59)
            {
                GameTimeSec += Time.deltaTime;
            }
            else
            {
                if (GameTimeSec >= 59)
                {
                    GameTime += 1;
                    GameTimeSec = 0;
                }
            }
        }
        

        if (TotalInHand == 0)
        {
            Money.SetActive(false);
        }
        else
        {
            Renderer renderer = Money.GetComponent<Renderer>();
            Money.SetActive(true);
            if (InHand10 > 0)
            {
                renderer.material = TenLe;
            }
            else
            {
                if (InHand20 > 0)
                {
                    renderer.material = TwentyLe;
                }
                else
                {
                    if (InHand50 > 0)
                    {
                        renderer.material = FiftyLe;
                    }
                    else
                    {
                        if (InHand100 > 0)
                        {
                            renderer.material = HundredLe;
                        }
                        else
                        {
                            if (InHand200 > 0)
                            {
                                renderer.material = TwoHundredLe;
                            }
                        }
                    }
                }
            }
        }

        if (printTicketStarted == true)
        {
            if (ticket.transform.position.y <= 1.382f)
            {
                ticket.transform.Translate(0, Time.deltaTime, 0, Space.World);
            }
        }
        /*if (arrived == true)
        {
            laptopcanvas.enabled = true;
        }
        else
        {
            laptopcanvas.enabled = false;
        }*/
        
        TotalInHand = (10 * InHand10) + (20 * InHand20) + (50 * InHand50) + (100 * InHand100) + (200 * InHand200);
        TotalInDrawer = (10 * InDrawer10) + (20 * InDrawer20) + (50 * InDrawer50) + (100 * InDrawer100) + (200 * InDrawer200);
        //InDrawer100Text.text = "100: " + InDrawer100;
        //InDrawer20Text.text = "20: " + InDrawer20;
        //InDrawer50Text.text = "50: " + InDrawer50;
        //InDrawer200Text.text = "200: " + InDrawer200;
        //InDrawer10Text.text = "10: " + InDrawer10;

        Timer -= Time.deltaTime;
        if (Timer <= 0f)
        {
            if (NoOfCars < 4)
            {
                NoOfCars += 1;
                int RandomNum = Random.Range(1, 3);
                if (RandomNum == 1)
                {
                    CarClone = Instantiate(car, new Vector3(-5.7f, 1.1f, 85f), transform.rotation) as GameObject;
                    Timer=3f;
                }
                else
                {
                    BusClone = Instantiate(bus, new Vector3(-7.48f, -0.34f, 85f), transform.rotation) as GameObject;
                    Timer = 3f;
                    
                }
            }
        }

        if (DecTime == true)
        {
            TextTimer -= Time.deltaTime;
            if (TextTimer <= 0)
            {
                problemOutput = "";
                DecTime = false;
                TextTimer = 2f;
            }
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Pause();
        }

    }

    public void AddMoney()
    {
        InDrawer10 += 5;
        InDrawer20 += 5;
        InDrawer50 += 2;
        InDrawer100 += 1;
    }

    public void ClearHand()
    {
        if (InHand10 > 0)
        {
            InDrawer10 += InHand10;
            InHand10 = 0;
        }

        if (InHand100 > 0)
        {
            InDrawer100 += InHand100;
            InHand100 = 0;
        }

        if (InHand200 > 0)
        {
            InDrawer200 += InHand200;
            InHand200 = 0;
        }

        if (InHand20 > 0)
        {
            InDrawer20 += InHand20;
            InHand20 = 0;
        }

        if (InHand50 > 0)
        {
            InDrawer50 += InHand50;
            InHand50 = 0;
        }
    }

    public void printTicket()
    {
        if (availableTicket > 0)
        {
            problemOutput = "You have an available ticket";
            DecTime = true;
            TextTimer = 2f;
        }
        else
        {
            printTicketStarted = true;
            availableTicket += 1;
            MoneyMade += MoneyToBeMade;
        }
    }

    public void GiveMoneyAndTicket()
    {
        if (availableTicket >= 1)
        {
            //Camera to move left and right
            //camera1.GetComponent<Animator>().SetBool("StartMovingToCar", true);
            printTicketStarted = false;
            ticket.transform.position = new Vector3(-0.88f, 1.232f, -1.032f);
            arrived = false;
            availableTicket -= 1;
            Car.receivedMoney = TotalInHand;
            Bus.receivedMoney = TotalInHand;
            InHand10 = 0;
            InHand100 = 0;
            InHand20 = 0;
            InHand200 = 0;
            InHand50 = 0;
            given = true;
        }
        else
        {
            problemOutput = "Please print a ticket first";
            DecTime = true;
            TextTimer = 2f;
        }
    }

    public void GetChange()
    {
        if (InDrawer200 > 0)
        {
            InDrawer200 -= 1;
            InDrawer100 += 1;
            InDrawer20 += 3;
            InDrawer10 += 4;
        }
        else
        {
            if (InDrawer100 > 0)
            {
                InDrawer20 += 3;
                InDrawer10 += 4;
                InDrawer100 -= 1;
            }
            else
            {
                if (InDrawer50 > 0)
                {
                    InDrawer50 -= 1;
                    InDrawer20 += 1;
                    InDrawer10 += 3;
                }
                else
                {
                    if (InDrawer20 > 0)
                    {
                        InDrawer20 -= 1;
                        InDrawer10 += 2;
                    }
                    else
                    {
                        problemOutput = "Can't change money";
                        DecTime = true;
                        TextTimer = 2f;
                    }
                }
            }
        }
    }


    public void Quitty()
    {
        Application.Quit();
    }

    public void MainMenuMeth()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void Pause()
    {
        if (paused == false)
        {
            paused = true;
            Time.timeScale = 0;
            GameCanvas.SetActive(false);
            PausedCanvas.SetActive(true);
            Settingscanvas.SetActive(false);
            laptopcanvas.enabled = false;
            AreYouSureCanvas.SetActive(false);
        }
        else
        {
            paused = false;
            Time.timeScale = 1;
            GameCanvas.SetActive(true);
            PausedCanvas.SetActive(false);
            Settingscanvas.SetActive(false);
            laptopcanvas.enabled = true;
            AreYouSureCanvas.SetActive(false);
        }
    }

    public void Back()
    {
        GameCanvas.SetActive(false);
        PausedCanvas.SetActive(true);
        Settingscanvas.SetActive(false);
        laptopcanvas.enabled = false;
        AreYouSureCanvas.SetActive(false);
    }

    public void Settings()
    {
        GameCanvas.SetActive(false);
        PausedCanvas.SetActive(false);
        Settingscanvas.SetActive(true);
        laptopcanvas.enabled = false;
        AreYouSureCanvas.SetActive(false);
    }

    public void GameOver()
    {
        SceneManager.LoadScene("GameOver");
    }

    public void addScore()
    {
        Score += 1000;
    }

    public void addTime()
    {
        GameTime += 1;
    }

    public void decTime()
    {
        GameTime -= 1;
    }

    public void AreYouSureMenu()
    {
        AreYouSureCanvas.SetActive(true);
        GameCanvas.SetActive(false);
        PausedCanvas.SetActive(false);
        Settingscanvas.SetActive(false);
        laptopcanvas.enabled = false;
    }

}
