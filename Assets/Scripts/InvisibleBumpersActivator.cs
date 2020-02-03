using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvisibleBumpersActivator : MonoBehaviour
{
    invisibleBumper[] invisibleBumpers;
        
    // Start is called before the first frame update
    void Start()
    {
        invisibleBumpers = FindObjectsOfType<invisibleBumper>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Ball")
        {
            //for(int i =0; i<= invisibleBumpers;i++)
            //invisibleBumper.MakeVisible();
        }
    }
}
