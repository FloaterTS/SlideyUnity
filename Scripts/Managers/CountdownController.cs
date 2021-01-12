using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountdownController : MonoBehaviour
{
    public float countdownTime;
    public static bool started;
    public GameObject pauseButtonUI;

    private Text countdownDisplay;
    private float countdownLeft;
    private Rigidbody rb;

    void Start()
    {
        started = false;
        countdownDisplay = GetComponent<Text>();
        countdownLeft = countdownTime;
        rb = GameObject.FindWithTag("Player").GetComponent<Rigidbody>();
        rb.constraints = RigidbodyConstraints.FreezeAll;
        // Nu lasam jucatorul sa se miste pana la finalizarea numaratoarei inverse
    }

    void Update()
    {
        if(!started) //verificam daca numaratoarea s-a finalizat si actualizam textul
            countdownDisplay.text = countdownLeft.ToString("#.");
        countdownLeft -= Time.deltaTime;
        if (countdownLeft <= 0 && !started) //in cazul in care s-a finalizat, pornim jocul
        {
            rb.constraints = RigidbodyConstraints.None; //dezghetam jucatorul
            countdownDisplay.text = ""; // ascundem textul de numaratoare inversa
            pauseButtonUI.SetActive(true); //facem butonul de pauza vizibil
            started = true; //setam jocul ca fiind inceput
        }
    }
}
