using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopAnimation : MonoBehaviour
{

    public Camera camera1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StopCameraMoving()
    {
        this.GetComponent<Animator>().SetBool("StartMovingToCar", false);
    }
}
