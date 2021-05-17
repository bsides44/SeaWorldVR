using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firstPersonController : MonoBehaviour
{
    public Camera fPCamera;
    float leftRight;
    float inOut;
    float upDown;
    float rotLeftRight;
    float rotUpDown;

    void Update()
    {
        // float xAxisValue = Input.GetAxis("Horizontal");
        // float zAxisValue = Input.GetAxis("Vertical");

        //direction
        if (Input.GetKeyDown(KeyCode.LeftArrow)) { leftRight = leftRight - 1; };
        if (Input.GetKeyUp(KeyCode.LeftArrow)) { leftRight = 0; };
        if (Input.GetKeyDown(KeyCode.RightArrow)) { leftRight = leftRight + 1; };
        if (Input.GetKeyUp(KeyCode.RightArrow)) { leftRight = 0; };
        if (Input.GetKeyDown(KeyCode.Space)) { inOut = inOut + 1; };
        if (Input.GetKeyUp(KeyCode.Space)) { inOut = 0; };
        if (Input.GetKeyDown(KeyCode.UpArrow)) { upDown = upDown + 1; };
        if (Input.GetKeyUp(KeyCode.UpArrow)) { upDown = 0; };
        if (Input.GetKeyDown(KeyCode.DownArrow)) { upDown = upDown - 1; };
        if (Input.GetKeyUp(KeyCode.DownArrow)) { upDown = 0; };

        // rotation
        if (Input.GetKeyDown(KeyCode.A)) { rotLeftRight = rotLeftRight - 1; };
        if (Input.GetKeyUp(KeyCode.A)) { rotLeftRight = 0; };
        if (Input.GetKeyDown(KeyCode.D)) { rotLeftRight = rotLeftRight + 1; };
        if (Input.GetKeyUp(KeyCode.D)) { rotLeftRight = 0; };
        if (Input.GetKeyDown(KeyCode.W)) { rotUpDown = rotUpDown - 1; };
        if (Input.GetKeyUp(KeyCode.W)) { rotUpDown = 0; };
        if (Input.GetKeyDown(KeyCode.S)) { rotUpDown = rotUpDown + 1; };
        if (Input.GetKeyUp(KeyCode.S)) { rotUpDown = 0; };

        if (Camera.current != null)
        {
            Camera.current.transform.Translate(new Vector3(leftRight, upDown, inOut));
            Camera.current.transform.Rotate(rotUpDown, rotLeftRight, 0, Space.Self);
        }
    }
}
