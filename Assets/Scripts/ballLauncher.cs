using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballLauncher : MonoBehaviour
{
    Transform ballSpawnPoint;
    [SerializeField] GameObject prefabBall;
    [SerializeField] float ballSpeed;
    int ballsToLaunch;
    bool canLaunch = true;
   [SerializeField] int remainingBalls = 4;
    int inGameBalls = 0;
    bool launch = false;
    // Start is called before the first frame update
    void Start()
    {
        ballSpawnPoint = gameObject.transform;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(inGameBalls);
        checkLaunch();
        if (launch)
        {
            LaunchBall();
        }
        //if(Input.GetKeyDown("space")&& canLaunch)
        //{
        //    ballLaunched();
        //    GameObject ball = Instantiate(prefabBall, ballSpawnPoint);
        //    ball.GetComponent<Rigidbody2D>().velocity = Vector2.up * ballSpeed;
        //}
    }
    public void ballLaunched()
    {
        inGameBalls++;
        remainingBalls--;
        Debug.Log("remaining balls" + remainingBalls);
    }
    public void ballDestroyed()
    {
        inGameBalls--;
    }
    void checkLaunch()
    {
        if (inGameBalls <= 0)
        {
            canLaunch = true;
        }
        if (inGameBalls >0 || remainingBalls <=0)
        {
            canLaunch = false;
        }
    }
    public void additionalBall()
    {
        remainingBalls++;
    }
    public void LaunchBonusBall()
    {
        additionalBall();
        ballLaunched();
        GameObject ball = Instantiate(prefabBall, ballSpawnPoint);
        ball.GetComponent<Rigidbody2D>().velocity = Vector2.up * ballSpeed;
    }
     void LaunchBall()
    {
        Debug.Log("launch1");
        if (canLaunch)
        {
            ballLaunched();
            GameObject ball = Instantiate(prefabBall, ballSpawnPoint);
            ball.GetComponent<Rigidbody2D>().velocity = Vector2.up * ballSpeed;
            launch = false;
        }
    }
    public void clickedLauncher()
    {
        launch = true;
    }
}
