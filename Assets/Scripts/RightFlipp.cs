using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightFlipp : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void rightFlipperAction()
    {
            GetComponent<HingeJoint2D>().useMotor = true;   
    }
    public void stopMotor()
    {
        GetComponent<HingeJoint2D>().useMotor = false;
    }
}
