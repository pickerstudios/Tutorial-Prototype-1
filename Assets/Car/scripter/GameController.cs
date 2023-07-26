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

        // ���� ��ǲ���� ������ �ڵ����� �����δ�. 
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);

        // ���� ��ǲ���� ������ �ڵ����� ȸ���Ѵ�. 
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);

    }
}
