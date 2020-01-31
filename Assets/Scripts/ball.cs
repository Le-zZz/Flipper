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
}
