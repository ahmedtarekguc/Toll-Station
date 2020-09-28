using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyFollowMouse : MonoBehaviour
{
    public Vector3 screenPoint;
    public Vector3 offset;

    void Update()
    {
        screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
        offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
        Vector3 currScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
        Vector3 curPosition = Camera.main.ScreenToWorldPoint(currScreenPoint);
        this.transform.position = new Vector3(curPosition.x, curPosition.y, -1.032f);
    }

}
