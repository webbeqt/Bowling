﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Ball))]

public class DragLaunch : MonoBehaviour {

    private Ball ball;

    private Vector3 dragStart, dragEnd;
    private float startTime, endTime;


	// Use this for initialization
	void Start () {
        ball = GetComponent<Ball>();



	}
	
    public void DragStart() {
        
        // Capture time & position of drag start
        dragStart = Input.mousePosition;
        startTime = Time.time;

    }

    public void DragEnd() {

        // Input
        dragEnd = Input.mousePosition;
        endTime = Time.time;

        // Duration
        float dragDuration = endTime - startTime;

        // Velocity
        float launchSpeedX = (dragEnd.x - dragStart.x) / dragDuration;
        float launchSpeedZ = (dragEnd.y - dragStart.y) / dragDuration;

        Vector3 launchVelocity = new Vector3(launchSpeedX, 0, launchSpeedZ);

        // Launch the ball
        ball.Launch(launchVelocity);
    }

}
