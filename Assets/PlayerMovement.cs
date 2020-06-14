﻿using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 1000f;
    public float sidewaysForce = 500f;

    // Start is called before the first frame update
    void Start()
    {   
        Debug.Log("Player wurde erstellt");

        // Der Parameter von Rigidbody von Gravity wird auf "true" gesetzt
        rb.useGravity = true;
    }

    // Update is called once per frame
    // void Update() {  }

    /* FixedUpdate wird genutzt wenn es um Physikberechnungen geht, weil es hier besser berechnet wird.
    *   FixedUpdate läuft langsamer als als Update. Um Tasten abzugreifen wäre es also besser
    *   In Update die Tastenabzugreifen und Boolwerte zu nutzen um zu signalisieren, dass eine Bewegung passiert
    *   Diese kann man dann in FixedUpdate einsetzen.
    *   
    *   Es ist außerdem besser die Unity Funktionen zu nutzen für die Tasten und diese nicht
    *   zu hardcoden
    */
    void FixedUpdate()
    {
        // Time.deltaTime gibt die Zeit der vorherigen Funktionsdurchlaufes an
        // dadurch kann bei unterschiedliche FPS eine gleichmäßige Bewegung erfolgen
        rb.AddForce(0,0,forwardForce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime,0,0);
        } else if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime,0,0);
        } 
    }
}