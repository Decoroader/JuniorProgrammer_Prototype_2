using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float cookiSpeed = 13.0f;
    private float topBound = 30.0f;

    //void FixedUpdate()
    //{
    //    transform.Translate(Vector3.forward * Time.deltaTime * cookiSpeed);
    //}
    /*
    why not for separately projectiles and animals; 
    rename the script to Projectile Control and enter the following:
    */void FixedUpdate()
    {
        transform.Translate(Vector3.forward* Time.deltaTime* cookiSpeed);
        if (transform.position.z > topBound)
            Destroy(gameObject);
    }
    
}
