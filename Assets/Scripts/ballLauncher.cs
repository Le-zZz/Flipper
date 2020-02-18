using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ballLauncher : MonoBehaviour
{
    Transform ballSpawnPoint;
    [SerializeField] GameObject prefabBall;
    [SerializeField] float ballSpeed;
    int ballsToLaunch;
    bool canLaunch = true;
   [SerializeField] int remainingBalls = 4;

   public int RemainingBalls
   {
       get => remainingBalls;
       set => remainingBalls = value;
   }

   int inGameBalls = 0;
    bool launch = false;

    [SerializeField] private TextMeshProUGUI textBall;

    [SerializeField] private GameObject gameOverPanelUI;

    [SerializeField] AudioSource gameMusic;
    [SerializeField] AudioSource launcher;
    [SerializeField] AudioSource gameover;
   
    // Start is called before the first frame update
    void Start()
    {
        ballSpawnPoint = gameObject.transform;
        gameMusic.Play();
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(inGameBalls);
        checkLaunch();
        //if (launch)
        //{
        //    LaunchBall();
        //}
        //if(Input.GetKeyDown("space")&& canLaunch)
        //{
        //    ballLaunched();
        //    GameObject ball = Instantiate(prefabBall, ballSpawnPoint);
        //    ball.GetComponent<Rigidbody2D>().velocity = Vector2.up * ballSpeed;
        //}
    }
    public void ballLaunched()
    {
        launcher.Play();
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
        textBall.text = remainingBalls.ToString();
        
        if (inGameBalls <= 0)
        {
            canLaunch = true;
        }
        if (inGameBalls > 0)
        {
            canLaunch = false;
        }
        if(remainingBalls <= 0 && inGameBalls <= 0)
        {
            canLaunch = false;
            ActivateGameOverPanel();
            gameover.Play();
            gameMusic.Stop();
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
        LaunchBall();
    }
    public void ActivateGameOverPanel()
    {
        Time.timeScale = 0f;
        gameOverPanelUI.SetActive(true);
    }
}
