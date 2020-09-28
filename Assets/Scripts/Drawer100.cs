using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Drawer100 : MonoBehaviour, IPointerClickHandler
{

    public Sprite HundredLe;
    public Sprite Black;
    public Text HundredText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Player.InDrawer100 > 0)
        {
            this.GetComponent<Image>().sprite = HundredLe;
            HundredText.text = "";
        }
        else
        {
            this.GetComponent<Image>().sprite = Black;
            HundredText.text = "100";
        }
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (eventData.button == PointerEventData.InputButton.Left)
        {
            if (Player.InDrawer100 > 0)
            {
                Player.InDrawer100 -= 1;
                Player.InHand100 += 1;
            }
        }

        if (eventData.button == PointerEventData.InputButton.Right)
        {
            if (Player.InHand100 > 0)
            {
                Player.InDrawer100 += 1;
                Player.InHand100 -= 1;
            }
        }
    }
}
