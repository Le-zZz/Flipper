using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
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
