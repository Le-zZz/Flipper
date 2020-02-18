using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touchControls : MonoBehaviour
{
    flipperBar flipperBar;
    RightFlipp rightFlipp;
    ballLauncher ballLauncher;
    // Start is called before the first frame update
    void Start()
    {
        flipperBar = FindObjectOfType<flipperBar>();
        rightFlipp = FindObjectOfType<RightFlipp>();
        ballLauncher = FindObjectOfType<ballLauncher>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Input.touchCount);
        if(Input.GetMouseButtonDown(0))
        {
            Vector3 touchPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            if(touchPosition.x > 0 && touchPosition.x < 2)
            {
                rightFlipp.rightFlipperAction();
            }
            else if( touchPosition.x < 0)
            {
                flipperBar.leftFlipperAction();
            }
            else if(touchPosition.x > 2 && touchPosition.y < -3)
            {
                Debug.Log("launch");
                ballLauncher.clickedLauncher();
            }
           
        }
        else if(Input.GetMouseButtonUp(0))
        {
            flipperBar.stopMotor();
            rightFlipp.stopMotor();
        }
        
    }
}
