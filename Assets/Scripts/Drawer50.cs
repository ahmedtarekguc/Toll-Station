using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Drawer50 : MonoBehaviour, IPointerClickHandler
{

    public Sprite FiftyLe;
    public Sprite Black;
    public Text fiftyText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Player.InDrawer50 > 0)
        {
            this.GetComponent<Image>().sprite = FiftyLe;
            fiftyText.text = "";

        }
        else
        {
            this.GetComponent<Image>().sprite = Black;
            fiftyText.text = "50";
        }
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (eventData.button == PointerEventData.InputButton.Left)
        {
            if (Player.InDrawer50 > 0)
            {
                Player.InDrawer50 -= 1;
                Player.InHand50 += 1;
            }
        }

        if (eventData.button == PointerEventData.InputButton.Right)
        {
            if (Player.InHand50 > 0)
            {
                Player.InDrawer50 += 1;
                Player.InHand50 -= 1;
            }
        }
    }
}
