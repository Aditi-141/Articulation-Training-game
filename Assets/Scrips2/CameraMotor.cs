﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMotor : MonoBehaviour
{
    private Transform lookAt;
    private Vector3 startOffset;
    private Vector3 moveVector;


    private float transition = 0.0f;
    private float animationDuration = 3.0f;
    private Vector3 animationOffset = new Vector3(0, 5, 5);

    // Start is called before the first frame update
    void Start()
    {
        lookAt = GameObject.FindGameObjectWithTag("Player").transform;
        startOffset = transform.position - lookAt.position;
    }

    // Update is called once per frame
    void Update()
    {
        moveVector = lookAt.position + startOffset;

        //x
        moveVector.x = 0;

        //y
        moveVector.y = Mathf.Clamp(moveVector.y, 3, 5);

        if(transition > 1.0f) {
            transform.position = lookAt.position + startOffset;
        }
        else
        {
            transform.position = Vector3.Lerp(moveVector + animationOffset, moveVector, transition);
            transition += Time.deltaTime * 1 / animationDuration;
            transform.LookAt(lookAt.position + Vector3.up);
        }
    }
}
