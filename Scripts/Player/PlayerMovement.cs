using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public GameManager gameManager;
    public PauseController pauseController;
    public Rigidbody rb;
    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;
    public float delay;

    private float delayTime;
    private Vector3 theVelocity;


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.X) || Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.Space))
        {
            pauseController.PauseOrResume();
        }
    }

    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime); // folosim AddForce pentru a adauga viteza de miscare pe axa Oz (inainte)
        if (Input.GetKey("d") || Input.GetKey(KeyCode.RightArrow)) // daca tasta "d" este apasata, se adauga viteza de miscare pe axa Ox cu valori pozitive
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a") || Input.GetKey(KeyCode.LeftArrow)) // daca tasta "d" este apasata, se adauga viteza de miscare pe axa Ox cu valori negative
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f) // trigger pentru terminarea scenei, daca player-ul a cazut de pe platforma
        {
            gameManager.EndGame();
        }
    }
}
