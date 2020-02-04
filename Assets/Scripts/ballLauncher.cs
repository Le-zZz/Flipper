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

    // Start is called before the first frame update
    void Start()
    {
        ballSpawnPoint = gameObject.transform;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(inGameBalls);
        checkLaunch();
        if(Input.GetKeyDown("space")&& canLaunch)
        {
            ballLaunched();
            GameObject ball = Instantiate(prefabBall, ballSpawnPoint);
            ball.GetComponent<Rigidbody2D>().velocity = Vector2.up * ballSpeed;
        }
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
}
