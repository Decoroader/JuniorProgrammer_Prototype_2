using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    private int lockButtonCounter = 0;
    private readonly int lockButtonTime = 33;
    void FixedUpdate()
    {
        // On spacebar press, send dog
        if(lockButtonCounter > 0)
            lockButtonCounter--;
        if (Input.GetKeyDown(KeyCode.Space) && (lockButtonCounter <= 0))
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            lockButtonCounter = lockButtonTime;
        }
    }
}
