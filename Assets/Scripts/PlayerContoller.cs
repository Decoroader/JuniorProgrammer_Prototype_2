using System;
using UnityEngine;

public class PlayerContoller : MonoBehaviour
{
    public float horizontalInput;
	private float speed = 25.0f;
    private float range = 20.0f;

	public GameObject projectilePrefab;

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

		if (Input.GetKeyDown(KeyCode.Space))
			Instantiate(projectilePrefab, new Vector3(transform.position.x, 
				transform.position.y + 1, transform.position.z), transform.rotation);
	}
}
