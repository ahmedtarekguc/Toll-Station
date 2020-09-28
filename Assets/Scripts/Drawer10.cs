using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Drawer10 : MonoBehaviour, IPointerClickHandler
{
    public Sprite TenLe;
    public Sprite Black;
    public Text TenText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Player.InDrawer10 > 0)
        {
            this.GetComponent<Image>().sprite = TenLe;
            TenText.text = "";
        }
        else
        {
            this.GetComponent<Image>().sprite = Black;
            TenText.text = "10";
        }
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (eventData.button == PointerEventData.InputButton.Left)
        {
            if (Player.InDrawer10 > 0)
            {
                Player.InDrawer10 -= 1;
                Player.InHand10 += 1;
            }
        }

        if (eventData.button == PointerEventData.InputButton.Right)
        {
            if (Player.InHand10 > 0)
            {
                Player.InDrawer10 += 1;
                Player.InHand10 -= 1;
            }
        }
    }
}
