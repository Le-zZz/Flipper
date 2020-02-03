using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingBumper : MonoBehaviour
{
    Rigidbody2D body;
    [SerializeField]float rotationSpeed = 20;
    // Start is called before the first frame update
    void Start()
    {
        body = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
    }
}
