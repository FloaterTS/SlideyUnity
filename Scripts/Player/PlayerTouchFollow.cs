using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Implementarea pe mobil a jocului
public class PlayerTouchFollow : MonoBehaviour
{
    public GameManager gameManager;
    public Touch touch;
    public float forwardForce = 2000f;
    public float speedModifier;
    public float delay;

    private float delayTime;
    private Rigidbody rb;
    private Vector3 theVelocity;


    public void Start()
    {
        speedModifier = 0.03f;
        rb = GetComponent<Rigidbody>();
        delayTime = delay;
    }

    public void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            rb.position = new Vector3(
                    rb.position.x + touch.deltaPosition.x * speedModifier,
                    rb.position.y,
                    rb.position.z);
        }
        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }

    }
}

