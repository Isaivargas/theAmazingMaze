﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxis("horizontal");
        float moveVertical = Input.GetAxis("vertical");

        Vector3 movement = new Vector3(moveHorizontal,0.00f,moveVertical);

        rb.AddForce(movement * 110);
    }
}