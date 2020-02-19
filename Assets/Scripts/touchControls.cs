using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class touchControls : MonoBehaviour
{
    flipperBar flipperBar;
    RightFlipp rightFlipp;
    ballLauncher ballLauncher;

    private Animator animator;

    private bool moveAllowed = false;

    private bool hasLaunched = false;
    
    void Start()
    {
        flipperBar = FindObjectOfType<flipperBar>();
        rightFlipp = FindObjectOfType<RightFlipp>();
        ballLauncher = FindObjectOfType<ballLauncher>();
        
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (ballLauncher.InGameBalls == 0)
        {
            hasLaunched = false;
        }
        
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            Vector3 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);

            if (touch.phase == TouchPhase.Began)
            {
                if (animator != null && !hasLaunched)
                {
                    animator.SetBool("MovementEnd", false);
                }

                Collider2D touchedCollider = Physics2D.OverlapPoint(touchPosition);

                if (hasLaunched)
                {
                    if (touchPosition.x > 0 && touchPosition.x < 2)
                    {
                        rightFlipp.rightFlipperAction();
                    }
                    else if (touchPosition.x < 0)
                    {
                        flipperBar.leftFlipperAction();
                    }
                }
                else if (!hasLaunched)
                {
                    if (touchPosition.x > 2 && touchPosition.y < -3)
                    {
                        moveAllowed = true;
                    }
                }
            }

            if (touch.phase == TouchPhase.Moved && moveAllowed && animator != null && !hasLaunched)
            {
                if (touchPosition.x > 2 && touchPosition.y < -3)
                {
                    animator.SetFloat("YMovement", touch.position.y);
                }
            }

            if (touch.phase == TouchPhase.Ended) 
            {
                flipperBar.stopMotor();
                rightFlipp.stopMotor();
                
                if (touchPosition.x > 2 && touchPosition.y < -3)
                {
                    ballLauncher.clickedLauncher();
                }

                if (animator != null && !hasLaunched)
                {
                    animator.SetBool("MovementEnd", true);
                    hasLaunched = true;
                }
                
                moveAllowed = false;
            }
        }
    }
    
}
