using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDrive : MonoBehaviour
{
    /*[SerializeField] WheelCollider frontRight;
    [SerializeField] WheelCollider backRight;
    [SerializeField] WheelCollider frontLeft;
    [SerializeField] WheelCollider backLeft;*/

    /*public float acceleration = 500f;
    public float brakeForce = 300f;
    public float maxTurnAngle = 15f;
    private float currentAcceleration = 0f;
    private float currentBrakeForce = 0f;
    private float currentTurnAngle = 0f;*/
    public Rigidbody rb;
    public Transform player;
    public float speed = 17;
    Vector3 forward = new Vector3(0, 0, -1);
    Vector3 backward = new Vector3(0, 0, 1);
    Vector3 right = new Vector3(0, 80, 0);
    Vector3 left = new Vector3(0, -80, 0);

    public SFXManager sfxManager;


    void Start()
    {
        sfxManager.PlaySound("Engine");    
    }

    void FixedUpdate()
    {
        /*if (Input.GetKeyDown(KeyCode.W))
        {
            currentAcceleration = acceleration * Input.GetAxis("Vertical");
        }

        if (Input.GetKey(KeyCode.Space))
        {
            currentBrakeForce = brakeForce;
        }
        else
        {
            currentBrakeForce = 0f;
        }

        frontRight.brakeTorque = currentBrakeForce;
        frontLeft.brakeTorque = currentBrakeForce;
        backRight.brakeTorque = currentBrakeForce;
        backLeft.brakeTorque = currentBrakeForce;

        currentTurnAngle = maxTurnAngle * Input.GetAxis("Horizontal");
        frontLeft.steerAngle = currentTurnAngle;
        frontRight.steerAngle = currentTurnAngle;*/


        //Allows the movement of the cars
        if (Input.GetKey("w"))
        {
            transform.Translate(forward * speed * Time.deltaTime);
        }
        if (Input.GetKey("s"))
        {
            transform.Translate(backward * speed * Time.deltaTime);
        }
        if (Input.GetKey("a"))
        {
            Quaternion deltaRotationLeft = Quaternion.Euler(left * Time.deltaTime);
            rb.MoveRotation(rb.rotation * deltaRotationLeft);
        }
        if (Input.GetKey("d"))
        {
            Quaternion deltaRotationRight = Quaternion.Euler(right * Time.deltaTime);
            rb.MoveRotation(rb.rotation * deltaRotationRight);
        }
    }
}
