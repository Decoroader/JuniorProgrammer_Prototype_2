using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float cookiSpeed = 13.0f;
    void FixedUpdate()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * cookiSpeed);
    }
}
