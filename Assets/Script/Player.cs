using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float playerVelocity;
    void Update()
    {
       if (Input.GetKey(KeyCode.A)) 
       {
        transform.position = new Vector2(transform.position.x - playerVelocity, transform.position.y);
       }
       else if (Input.GetKey(KeyCode.D))
       {
        transform.position = new Vector2(transform.position.x + playerVelocity, transform.position.y);
       }

       if(transform.position.x < -6.5f)
       {
        transform.position = new Vector2 (-6.5f, transform.position.y);
       }
       else if (transform.position.x > 6.5f)
       {
        transform.position = new Vector2(6.5f, transform.position.y);
       }
    }
}
