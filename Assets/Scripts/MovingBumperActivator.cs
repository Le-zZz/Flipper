using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingBumperActivator : MonoBehaviour
{
    movingBumpers movingBumpers;
    // Start is called before the first frame update
    void Start()
    {
        movingBumpers = FindObjectOfType<movingBumpers>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Ball")
        {
            Debug.Log("yes");
            movingBumpers.Activate();
        }
    }
}
