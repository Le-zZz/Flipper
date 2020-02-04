using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    ballLauncher BallLauncher;
    // Start is called before the first frame update
    void Start()
    {
        BallLauncher = transform.parent.GetComponent<ballLauncher>();

        if (!BallLauncher)
        {
            Debug.Log("ERROR");
        }
    }

    // Update is called once per frame
    void Update()
    {
        //if(Input.GetKeyDown(KeyCode.Space))
        //{
        //    Camera.main.GetComponent<ScreenShakeBehavior>().TriggerShake(0.1f);
        //}
    }
    public void DestroyBall()
    {
        Debug.Log("destroy");
        BallLauncher.ballDestroyed();
        Destroy(gameObject);
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.layer == LayerMask.NameToLayer("CollisionObjects"))
        {
            Camera.main.GetComponent<ScreenShakeBehavior>().TriggerShake(0.1f);
        }


    }
}
