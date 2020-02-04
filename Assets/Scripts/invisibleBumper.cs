using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class invisibleBumper : MonoBehaviour
{
    SpriteRenderer sprite;
    CircleCollider2D collider;
    PolygonCollider2D PolygonCollider2D;
   [SerializeField] bool isVisible = true;
    [SerializeField] float visibleTime;
    float visibleTimer;
   
    // Start is called before the first frame update
    void Start()
    {
        sprite = gameObject.GetComponent<SpriteRenderer>();
        collider = gameObject.GetComponent<CircleCollider2D>();
        PolygonCollider2D = gameObject.GetComponent<PolygonCollider2D>();
    }

    enum State
    {
        INVISIBLE,
        VISIBLE
    }
    State state = State.INVISIBLE;
    // Update is called once per frame
    void Update()
    {
      switch(state)
        {
            case (State.INVISIBLE):
                visibleTimer = visibleTime;
                sprite.enabled = false;
                collider.enabled = false;
                PolygonCollider2D.enabled = false;
                if (isVisible)
                {
                    state = State.VISIBLE;
                }
                break;
            case (State.VISIBLE):
                visibleTimer -= Time.deltaTime;
                sprite.enabled = true;
                collider.enabled = true;
                PolygonCollider2D.enabled = true;
                if (visibleTimer <= 0)
                {
                    isVisible = false;
                    state = State.INVISIBLE;
                }
                break;
        }
    }
    public void MakeVisible()
    {
        isVisible = true;
    }
   
}
