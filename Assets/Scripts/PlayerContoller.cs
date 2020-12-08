using System;
using UnityEngine;

public class PlayerContoller : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 10.0f;
    private float range = 10.0f;
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        if (Math.Abs(transform.position.x) > range)
            transform.position = new Vector3(Math.Sign(transform.position.x)*range, 
                transform.position.y, transform.position.z);

        //      if (transform.position.x < -range)
        //      {
        //          transform.position = new Vector3(-range, transform.position.y, transform.position.z);
        //      }
        //      if (transform.position.x > range)
        //      {
        //          transform.position = new Vector3(range, transform.position.y, transform.position.z);
        //      }
        //        horizontalInput = Input.GetAxis("Horizontal");
        //        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
    }
}
