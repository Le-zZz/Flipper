using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    ballLauncher ballLauncher;
    Rigidbody2D body;
    // Start is called before the first frame update
    void Start()
    {
        ballLauncher = FindObjectOfType<ballLauncher>();
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //if(Input.GetKeyDown(KeyCode.Space))
        //{
        //    Camera.main.GetComponent<ScreenShakeBehavior>().TriggerShake(0.1f);
        //}
    }
    private void DestroyBall()
    {
        Debug.Log("1");
       ballLauncher.ballDestroyed();
        Destroy(gameObject);
    }
    private void OnBecameInvisible()
    {
        DestroyBall();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.layer == LayerMask.NameToLayer("CollisionObjects"))
        {
            Camera.main.GetComponent<ScreenShakeBehavior>().TriggerShake(0.1f);
        }
    }
}
