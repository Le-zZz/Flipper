using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdditionalBall : MonoBehaviour
{
    ballLauncher ballLauncher;
    // Start is called before the first frame update
    void Start()
    {
        ballLauncher = FindObjectOfType<ballLauncher>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Ball")
        {
            ballLauncher.LaunchBonusBall();
        }
    }
}
