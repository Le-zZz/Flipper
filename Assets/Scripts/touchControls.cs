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
        if (ballLauncher.RemainingBalls == 0)
        {
            
        }
        else
        {
            Debug.Log(Input.touchCount);
            if (Input.touchCount > 0)
            {
                Touch touch = Input.GetTouch(0);
                Vector3 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);

                if (touch.phase == TouchPhase.Began)
                {

                    Collider2D touchedCollider = Physics2D.OverlapPoint(touchPosition);

                    if (touchPosition.x > 0 && touchPosition.x < 2)
                    {
                        rightFlipp.rightFlipperAction();
                    }
                    else if (touchPosition.x < 0)
                    {
                        flipperBar.leftFlipperAction();
                    }
                    else if (touchPosition.x > 2 && touchPosition.y < -3)
                    {
                        Debug.Log("launch");
                        ballLauncher.clickedLauncher();
                    }
                }

                if (touch.phase == TouchPhase.Ended)
                {
                    flipperBar.stopMotor();
                    rightFlipp.stopMotor();
                }
            }
        }
    }
    
}
