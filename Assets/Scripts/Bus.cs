﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bus : MonoBehaviour
{

    public bool moving = true;
    int ToBePaid = 20;
    int randomPrice;
    int changeMoney;
    public static int receivedMoney = 0;

    // Start is called before the first frame update
    void Start()
    {
        this.transform.Rotate(0f, 180.0f, 0.0f, Space.Self);
        Random r = new Random();
        int[] priceArray = new int[] {20, 50, 100, 200 };
        var randomIndex = Random.Range(0, priceArray.Length);
        randomPrice = priceArray[randomIndex];
        changeMoney = randomPrice - ToBePaid;
        moving = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.z < -11)
        {
            Destroy(this.gameObject);
        }

        MoveCar();

        if (Player.given == true)
        {
            if (receivedMoney == changeMoney)
            {
                Player.Score += changeMoney;
                if (changeMoney == 0)
                {
                    Player.Score += 10;
                }
            }
            else
            {
                Player.Score -= changeMoney;
            }
            moving = true;
            Player.NoOfCars -= 1;
            Player.given = false;
            
        }
    }

    void MoveCar()
    {
        if (moving == true)
        {
            this.gameObject.transform.Translate(0, 0, 0.8f);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("NonPlayer"))
        {
            moving = false;
        }

        if (other.CompareTag("Player"))
        {
            moving = false;
            Player.given = false;
            Player.MoneyToBeMade = 20;
            Player.MoneyReceived = randomPrice;

            if (randomPrice == 20)
            {
                int random20 = Random.Range(1, 3);
                if (random20 == 1)
                {
                    Player.InHand10 += 2;
                }
                else
                {
                    Player.InHand20 += 1;
                }
            }

            if (randomPrice == 50)
            {
                Player.InHand50 += 1;
            }

            if (randomPrice == 100)
            {
                Player.InHand100 += 1;
            }

            if (randomPrice == 200)
            {
                Player.InHand200 += 1;
            }
            randomPrice = 0;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("NonPlayer"))
        {
            moving = true;
        }

        if (other.CompareTag("NonPlayer"))
        {
            Player.MoneyReceived = 0;
        }
    }
}
