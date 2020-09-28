using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Drawer20 : MonoBehaviour, IPointerClickHandler
{

    public Sprite TwentyLe;
    public Sprite Black;
    public Text TwentyText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Player.InDrawer20 > 0)
        {
            this.GetComponent<Image>().sprite = TwentyLe;
            TwentyText.text = "";
        }
        else
        {
            this.GetComponent<Image>().sprite = Black;
            TwentyText.text = "20";
        }
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (eventData.button == PointerEventData.InputButton.Left)
        {
            if (Player.InDrawer20 > 0)
            {
                Player.InDrawer20 -= 1;
                Player.InHand20 += 1;
            }
        }

        if (eventData.button == PointerEventData.InputButton.Right)
        {
            if (Player.InHand20 > 0)
            {
                Player.InDrawer20 += 1;
                Player.InHand20 -= 1;
            }
        }
    }
}
