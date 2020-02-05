using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    ballLauncher BallLauncher;
    Score score;
    [SerializeField] AudioSource hit;
    // Start is called before the first frame update
    void Start()
    {
        BallLauncher = transform.parent.GetComponent<ballLauncher>();
        score = FindObjectOfType<Score>();

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
        hit.Play();
        if(collision.gameObject.layer == LayerMask.NameToLayer("CollisionObjects"))
        {
            Camera.main.GetComponent<ScreenShakeBehavior>().TriggerShake(0.1f);
        }
        if(collision.gameObject.tag == "3Points")
        {
            score.ShowScore(3);
        }
        if(collision.gameObject.tag == "4Points")
        {
            score.ShowScore(4);
        }
        if(collision.gameObject.tag == "7Points")
        {
            score.ShowScore(7);
        }
        if(collision.gameObject.tag == "5Points")
        {
            score.ShowScore(5);
        }

    }
}
