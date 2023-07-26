using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0, 3.7f, -14.5f);

    void LateUpdate()
    {
        transform.position = player.transform.position + offset ;
    }
}
