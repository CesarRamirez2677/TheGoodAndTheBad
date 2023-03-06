using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cone : MonoBehaviour
{
   public float playerVelocity;
   public Rigidbody2D rb2d;
    void Update()
    {
        rb2d.velocity = new Vector2(0, playerVelocity);
    }
}
