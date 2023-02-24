using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wheel : MonoBehaviour
{
    private WheelJoint2D _wheel;
    private JointMotor2D _motor;
    public float Speed;

    private void Start()
    {
        _wheel = GetComponent<WheelJoint2D>();
        _motor = _wheel.motor;
    }

    private void Update()
    {
        float Force = Input.GetAxis("Horizontal");
        _motor.motorSpeed = Speed * -Force;
        _wheel.motor = _motor;
    }
}
