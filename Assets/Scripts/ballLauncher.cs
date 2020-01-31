using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballLauncher : MonoBehaviour
{
    Transform ballSpawnPoint;
    [SerializeField] GameObject prefabBall;
    [SerializeField] float ballSpeed;
    int ballsToLaunch;
    ballManager BallManager;
    

    // Start is called before the first frame update
    void Start()
    {
        ballSpawnPoint = gameObject.transform;
        BallManager = FindObjectOfType<ballManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("space"))
        {
            //BallManager.ballLaunched();
            GameObject ball = Instantiate(prefabBall, ballSpawnPoint);
            ball.GetComponent<Rigidbody2D>().velocity = Vector2.up * ballSpeed;
        }
    }
}
