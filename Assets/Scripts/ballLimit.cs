using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballLimit : MonoBehaviour
{
   [SerializeField] ball ball;

    private void Start()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Ball")

        {
            collision.gameObject.GetComponent<ball>().DestroyBall();
        }
    }
}
