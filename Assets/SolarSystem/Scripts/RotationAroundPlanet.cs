using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RotationAroundPlanet : MonoBehaviour {

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

    Quaternion rotation;
    Vector3 position;

    public float smoothTime = 0;

    private float xSmooth = 0.0f;
    private float ySmooth = 0.0f;
    private float xVelocity = 0.0f;
    private float yVelocity = 0.0f;

    private Vector3 posSmooth = Vector3.zero;
    
    bool mousePressed = false;

    public List<GameObject> planets;

	// Use this for initialization
	void Start () {
        Cursor.visible = true;

        var angles = transform.eulerAngles;
        x = angles.y;
        y = angles.x;

        // Make the rigid body not change rotation
        if (GetComponent<Rigidbody>())
            GetComponent<Rigidbody>().freezeRotation = true;

	}
	
    void Update()
    {
        
        //if (Input.GetMouseButton(1))
        //    mousePressed = true;
        //else if (Input.GetMouseButtonUp(1))
        //    mousePressed = false;
    }

	void LateUpdate () {


        if (target && Input.GetMouseButton(0))
        {
			x = transform.eulerAngles.y;
			y = transform.eulerAngles.x;

            x += Input.GetAxis("Mouse X") * xSpeed;
            y -= Input.GetAxis("Mouse Y") * ySpeed;
            
            xSmooth = Mathf.SmoothDamp(xSmooth, (float)x, ref xVelocity, smoothTime);
            ySmooth = Mathf.SmoothDamp(ySmooth, (float)y, ref yVelocity, smoothTime);

            //ySmooth = ClampAngle(ySmooth, yMinLimit, yMaxLimit);

            rotation = Quaternion.Euler(ySmooth, xSmooth, 0);

            // posSmooth = new Vector3.SmoothDamp(posSmooth,target.position, ref posVelocity,smoothTime);

            posSmooth = target.position; // no follow smoothing

            transform.rotation = rotation;
            transform.position = rotation * new Vector3(0.0f, 0.0f, -distance) + posSmooth;
        }


       
		rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler((float)y, (float)x, 0), Time.deltaTime * switchPlanetSmooth);

            position = rotation * new Vector3(0.0f, 0.0f, -distance) + target.position;

            transform.rotation = rotation;
            transform.position = position;
        
       

        if (Input.GetAxis("Mouse ScrollWheel") != 0)
        {

            if (distance >= MouseZoomMin && distance <= MouseZoomMax)
            {

                distance -= Input.GetAxis("Mouse ScrollWheel") * MouseWheelSensitivity;

                if (distance < MouseZoomMin) { distance = MouseZoomMin; }
                if (distance > MouseZoomMax) { distance = MouseZoomMax; }
            }
        }
	}

    static float ClampAngle (float angle,float min,float max) 
    {
        if (angle < -360)
            angle = 360;
        if (angle > 360)
            angle = 360;
        return Mathf.Clamp (angle, min, max);
    }
}
