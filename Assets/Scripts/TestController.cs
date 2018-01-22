using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestController : MonoBehaviour {

    public Rigidbody rb;

    public float moveSpeed;
    public float tiltSpeed;
    public float rotateSpeed;

    private void FixedUpdate()
    {
        HandleInput();
    }

    void HandleInput() {
        if (Input.GetKey(KeyCode.LeftShift)) {
            MoveForward();
        }

        if (Input.GetKey(KeyCode.LeftControl)) {
            MoveBackwords();
        }

        if (Input.GetKey(KeyCode.A)) {
            TiltLeft();
        }

        if (Input.GetKey(KeyCode.D)) {
            TiltRight();
        }

        if (Input.GetKey(KeyCode.S))
        {
            TiltUp();
        }

        if (Input.GetKey(KeyCode.W)) {
            TiltDown();
        }

        if (Input.GetKey(KeyCode.Q)) {
            RotateLeft();
        }

        if (Input.GetKey(KeyCode.E)) {
            RotateRight();
        }
    }

    #region Movement
    public void MoveForward() {
        rb.velocity = transform.forward * moveSpeed;
    }

    public void MoveBackwords() {
        rb.velocity = transform.forward * -moveSpeed;
    }

    public void TiltLeft() {
        rb.AddTorque(-transform.up * tiltSpeed, ForceMode.Acceleration);
    }

    public void TiltRight() {
        rb.AddTorque(transform.up * tiltSpeed, ForceMode.Acceleration);
    }

    public void TiltUp() {
        rb.AddTorque(-transform.right * tiltSpeed);
    }

    public void TiltDown() {
        rb.AddTorque(transform.right * tiltSpeed);
    }

    public void RotateLeft() {
        Vector3 vector = transform.TransformDirection(new Vector3(0, 0, rotateSpeed));
        rb.AddTorque(vector, ForceMode.Acceleration);
    }

    public void RotateRight() {
        Vector3 vector = transform.TransformDirection(new Vector3(0, 0, -rotateSpeed));
        rb.AddTorque(vector, ForceMode.Acceleration);
    }
    #endregion

}