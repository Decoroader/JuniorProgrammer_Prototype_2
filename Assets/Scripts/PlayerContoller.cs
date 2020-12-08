using UnityEngine;

public class PlayerContoller : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 10.0f;
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
    }
}
