﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RotationAroundPlanet : MonoBehaviour
{

    public Transform target;
    public float distance = 5f;

    // ZoomCameraMouse
    public float MouseWheelSensitivity = 1;
    public float MouseZoomMin = 1.5f;
    public float MouseZoomMax = 18;

    public float xSpeed = 40.0f;
    public float ySpeed = 40.0f;

    public float yMinLimit = -360.0f;
    public float yMaxLimit = 360.0f;

    public float switchPlanetSmooth = 0.8f;

    private double x = 80.0f;
    private double y = 50.0f;

    public float minFov = 40.0f;
    public float fovZoomSensitivity = 8.0f;
    public float fovDefault = 60.0f;

    Quaternion rotation;
    Vector3 position;

    public float smoothTime = 0;

    private float xSmooth = 0.0f;
    private float ySmooth = 0.0f;
    private float xVelocity = 0.0f;
    private float yVelocity = 0.0f;

    private Vector3 posSmooth = Vector3.zero;
    
    public List<GameObject> planets;
    
    // Use this for initialization
    void Start()
    {
        Cursor.visible = true;

        var angles = transform.eulerAngles;
        x = angles.y;
        y = angles.x;

        // Make the rigid body not change rotation
        if (GetComponent<Rigidbody>())
            GetComponent<Rigidbody>().freezeRotation = true;

    }

    void LateUpdate()
    {

        // Ignore UI Layer so we won't rotate or scroll planets on UI
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        var raycast = Physics.Raycast(ray, 50000, LayerMask.NameToLayer("UI"));

        if (Input.GetMouseButton(2))
        {
            x = Input.GetAxis("Mouse X") * xSpeed / 100;
            y = Input.GetAxis("Mouse Y") * ySpeed / 100;

            transform.Translate(float.Parse(x.ToString()), float.Parse(y.ToString()), 0);
        }
        else
        {
            transform.rotation = rotation;
            transform.position = rotation * new Vector3(0.0f, 0.0f, -distance) + posSmooth;

            rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler((float)y, (float)x, 0), Time.deltaTime * switchPlanetSmooth);

            position = rotation * new Vector3(0.0f, 0.0f, -distance) + target.position;

            transform.rotation = rotation;
            transform.position = position;
        }

        if (raycast && Input.GetMouseButton(0))
        {
            x = transform.eulerAngles.y;
            y = transform.eulerAngles.x;

            x += Input.GetAxis("Mouse X") * xSpeed;
            y -= Input.GetAxis("Mouse Y") * ySpeed;

            xSmooth = Mathf.SmoothDamp(xSmooth, (float)x, ref xVelocity, Time.deltaTime * smoothTime);
            ySmooth = Mathf.SmoothDamp(ySmooth, (float)y, ref yVelocity, Time.deltaTime * smoothTime);

            //ySmooth = ClampAngle(ySmooth, yMinLimit, yMaxLimit);

            rotation = Quaternion.Euler(ySmooth, xSmooth, 0);

            // posSmooth = new Vector3.SmoothDamp(posSmooth,target.position, ref posVelocity,smoothTime);

            posSmooth = target.position; // no follow smoothing

        }

        if (raycast && Input.GetAxis("Mouse ScrollWheel") != 0)
        {
            if (distance >= MouseZoomMin && distance <= MouseZoomMax)
            {
                distance -= Input.GetAxis("Mouse ScrollWheel") * MouseWheelSensitivity;

                if (distance < MouseZoomMin) { distance = MouseZoomMin; }
                if (distance > MouseZoomMax) { distance = MouseZoomMax; }
            }

            // Once distance is equal to mouse zoom min we want to change fov for camera

            if (distance <= MouseZoomMin && Camera.main.fieldOfView >= minFov)
            {
                Camera.main.fieldOfView -= Input.GetAxis("Mouse ScrollWheel") * fovZoomSensitivity / distance;
            }

            if (Camera.main.fieldOfView < fovDefault && Input.GetAxis("Mouse ScrollWheel") < 0f)
            {
                Camera.main.fieldOfView -= Input.GetAxis("Mouse ScrollWheel") * fovZoomSensitivity / distance;
            }
        }
    }
}