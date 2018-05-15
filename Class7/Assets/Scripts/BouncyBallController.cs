using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncyBallController : MonoBehaviour
{
    public GameController gameRef;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        string name = collision.gameObject.name;
        if (name == "Trigger")
        {
            gameRef.AddPoints();
            // Moving to another place.
            gameObject.transform.position = new Vector2(2,2);
        }
    }
}
