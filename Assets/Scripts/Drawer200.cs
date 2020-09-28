using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Drawer200 : MonoBehaviour, IPointerClickHandler
{

    public Sprite TwoHundredLe;
    public Sprite Black;
    public Text TwoHundredText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Player.InDrawer200 > 0)
        {
            this.GetComponent<Image>().sprite = TwoHundredLe;
            TwoHundredText.text = "";
        }
        else
        {
            this.GetComponent<Image>().sprite = Black;
            TwoHundredText.text = "200";
        }
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (eventData.button == PointerEventData.InputButton.Left)
        {
            if (Player.InDrawer200 > 0)
            {
                Player.InDrawer200 -= 1;
                Player.InHand200 += 1;
            }
        }

        if (eventData.button == PointerEventData.InputButton.Right)
        {
            if (Player.InHand200 > 0)
            {
                Player.InDrawer200 += 1;
                Player.InHand200 -= 1;
            }
        }
    }
}
