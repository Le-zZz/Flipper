using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flipperBar : MonoBehaviour
{
    //[SerializeField] Vector3 rotatePoint;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
            if (Input.GetKeyDown("n")&& gameObject.tag == "RightFlipper"|| Input.GetKeyDown("c")&& gameObject.tag == "LeftFlipper")
            {
                GetComponent<HingeJoint2D>().useMotor = true;
            }
            if (Input.GetKeyUp("n") && gameObject.tag == "RightFlipper" || Input.GetKeyUp("c") && gameObject.tag == "LeftFlipper")
        {
                GetComponent<HingeJoint2D>().useMotor = false;
            }
        
        
    }
}
