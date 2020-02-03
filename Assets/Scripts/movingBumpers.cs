using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingBumpers : MonoBehaviour
{
    Rigidbody2D body;
    Vector3 startingPosition;
    float movingTimer;
   [SerializeField] float movingTime;
    [SerializeField] float movingSpeed = 1;
    bool switchDirection = false;
   [SerializeField] float rigthPosition;
   [SerializeField] float leftPosition;
    bool switched = false;
   [SerializeField] bool move = false;

    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        startingPosition = gameObject.transform.position;
        movingTimer = movingTime; // a deplacer
    }

    enum State
    {
        IDLE,
        MOVING,
        RETURNING_STARTING_POSITION
    }
    State state = State.IDLE;
    // Update is called once per frame
    void Update()
    {
        switch(state)
        {
            case State.IDLE:
                movingTimer = movingTime;
                if(move)
                {
                    state = State.MOVING;
                }
                break;
            case State.MOVING:
                movingTimer -= Time.deltaTime;
                if (!switchDirection)
                {
                    body.velocity = new Vector2(movingSpeed, body.velocity.y);
                }
                if (switchDirection)
                {
                    body.velocity = new Vector2(-movingSpeed, body.velocity.y);
                }
                //if(!switched)
                //{ 
                //    body.velocity = new Vector2(movingSpeed, body.velocity.y);
                //}
                //if(body.position.x == rigthPosition)
                //{
                //    switched = true;
                //    body.velocity = new Vector2(-movingSpeed, body.velocity.y);
                //}
                //else if(body.position.x== leftPosition)
                //{
                //    body.velocity = new Vector2(movingSpeed, body.velocity.y);
                //}
                if (movingTimer <= 0)
                {
                    state = State.RETURNING_STARTING_POSITION;
                }
                break;
            case State.RETURNING_STARTING_POSITION:
                move = false;
                body.velocity = (startingPosition - transform.position) * movingSpeed;
                if (transform.position.x - startingPosition.x <= 0.01f)
                {
                    state = State.IDLE;
                }
                break;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "RightWall")
        {
            switchDirection = true;
        }
        if (collision.gameObject.tag == "LeftWall")
        {
            switchDirection = false;
        }
    }
    public void Activate()
    {
        Debug.Log("okay");
        move = true;
    }
}
