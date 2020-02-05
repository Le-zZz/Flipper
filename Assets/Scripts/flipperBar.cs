using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flipperBar : MonoBehaviour
{
    //[SerializeField] Vector3 rotatePoint;
    bool leftFlipper = false;
    bool rightFlipper = false;
    [SerializeField] GameObject middleScreen;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        //if (Input.GetKeyDown("n") && gameObject.tag == "RightFlipper" || Input.GetKeyDown("c") && gameObject.tag == "LeftFlipper")
        //{
        //    GetComponent<HingeJoint2D>().useMotor = true;
        //}
        //if (Input.GetKeyUp("n") && gameObject.tag == "RightFlipper" || Input.GetKeyUp("c") && gameObject.tag == "LeftFlipper")
        //{
        //    GetComponent<HingeJoint2D>().useMotor = false;

            //if(Input.touchCount >0)
            //{
            //    Touch touch1 = Input.GetTouch(0);
            //    Touch touch2 = Input.GetTouch(1);
            //    if(touch1.position.x<middleScreen.transform.position.x&&gameObject.tag == "LeftFlipper")
            //    {
            //        GetComponent<HingeJoint2D>().useMotor = true;
            //    }
            //    if (touch2.position.x > middleScreen.transform.position.x && gameObject.tag == "RightFlipper")
            //    {
            //        GetComponent<HingeJoint2D>().useMotor = true;
            //    }
            //}

        }

    
   public void leftFlipperAction()
    {
            GetComponent<HingeJoint2D>().useMotor = true;
    }
    
    public void stopMotor()
    {
        GetComponent<HingeJoint2D>().useMotor = false;
    }
}

