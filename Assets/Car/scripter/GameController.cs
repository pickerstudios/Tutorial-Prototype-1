using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public float speed = 20f;
    public float turnSpeed;
    public float horizontalInput;
    public float forwardInput;

    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput    = Input.GetAxis("Vertical");

        // 수직 인풋으로 누르면 자동차가 움직인다. 
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);

        // 수평 인풋으로 누르면 자동차가 회전한다. 
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);

    }
}
