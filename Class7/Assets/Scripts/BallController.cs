using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{

    public Rigidbody2D ballBody;
    public GameController gameRef;
    private float forceX = 10.0f;
    private float forceY = 15.0f;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Vector2 forceLeft = new Vector2(-forceX, 0);
            ballBody.AddForce(forceLeft);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Vector2 forceRight = new Vector2(forceX, 0);
            ballBody.AddForce(forceRight);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            Vector2 forceUp = new Vector2(0, forceY);
            ballBody.AddForce(forceUp);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            Vector2 forceDown = new Vector2(0, -forceY);
            ballBody.AddForce(forceDown);
        }
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 v = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x,
                            Input.mousePosition.y, Camera.main.nearClipPlane));
            if (v.x < (transform.position.x + 1) && v.x > (transform.position.x - 1) &&
                v.y < (transform.position.y + 1) && v.y > (transform.position.y - 1))
            {
                ballBody.velocity = new Vector2(10, 10);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        string name = collision.gameObject.name;
        if (name == "Trigger")
        {
            gameRef.Lose();
            gameObject.SetActive(false);
        }
    }

}
