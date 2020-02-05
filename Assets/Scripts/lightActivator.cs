using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightActivator : MonoBehaviour
{
    [SerializeField] SpriteRenderer bumperLight;
    [SerializeField] SpriteRenderer score;
    [SerializeField] float lightTime;
    float lightTimer;
    bool lightON = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (lightON)
        {
            Activatedlight();
        }
    }
    void Activatedlight()
    {
        bumperLight.enabled = true;
        if (score != null)
        {
            score.enabled = true;
        }
        lightTimer -= Time.deltaTime;
        if (lightTimer <= 0)
        {
            lightON = false;
            bumperLight.enabled = false;
            if (score != null)
            {
                score.enabled = false;
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            lightTimer = lightTime;
            Debug.Log("oui");
            lightON = true;
        }
    }
}
