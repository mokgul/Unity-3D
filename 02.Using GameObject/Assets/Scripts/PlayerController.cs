using System;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10f;
    public float rotationSpeed = 50f;
    public float verticalInput;
    public float horizontalInput;


    // Update is called once per frame
    public void Update()
    {
        // get the user's vertical and horizontal input
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");
        

        //constant values for the tilt up/down and roll of the plane
        Vector3 tiltConstant = Vector3.left * rotationSpeed * Time.deltaTime * 0.5f;
        Vector3 rollConstant = Vector3.forward * rotationSpeed * Time.deltaTime * 0.5f;
        Vector3 horizontalTurn = Vector3.up * rotationSpeed * Time.deltaTime * 0.5f;


        // move the plane forward at a constant rate
        this.transform.Translate(Vector3.forward * Time.deltaTime * speed);

        // tilt the plane up/down based on up/down arrow keys
        this.PressedDownButton("Vertical", verticalInput, tiltConstant);

        //turn the plane left/right based on left/right keys
        this.PressedDownButton("Horizontal", horizontalInput, horizontalTurn);

        // roll the plane sideways based on q/e keys
        if (Input.GetKey(KeyCode.E) == true)
            this.transform.Rotate(rollConstant);
        if (Input.GetKey(KeyCode.Q) == true)
            this.transform.Rotate(-1 * rollConstant);
    }

    private void PressedDownButton(string direction, float value, Vector3 directionConst)
    {
        bool isButtonPressed = false;
        if (Input.GetAxisRaw(direction) != 0)
        {
            if (isButtonPressed == false)
            {
                this.transform.Rotate(directionConst * value);
                isButtonPressed = true;
            }
        }

        if (Input.GetAxisRaw(direction) == 0)
            isButtonPressed = false;
    }
}
