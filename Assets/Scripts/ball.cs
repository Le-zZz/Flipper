using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    ballManager BallManager;
    // Start is called before the first frame update
    void Start()
    {
        BallManager = FindObjectOfType<ballManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void Destroy()
    {
       // BallManager.ballLaunched();
        Destroy(gameObject);
    }
    private void OnBecameInvisible()
    {
        Destroy();
    }
}
