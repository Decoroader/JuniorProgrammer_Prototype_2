﻿using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speed = 5.0f;

	void FixedUpdate()
	{
		transform.Translate(Vector3.forward * Time.deltaTime * speed);
	}
}
