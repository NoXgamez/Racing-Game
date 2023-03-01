using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowObject : MonoBehaviour
{
    public GameObject objectToFollow;
    Vector3 targetPosition;

    void Update()
    {
        if(objectToFollow != null)
        {
            targetPosition.x = objectToFollow.transform.position.x;
            targetPosition.y = objectToFollow.transform.position.y;
            targetPosition.z = transform.position.z;

            transform.up = objectToFollow.transform.up;

            transform.position = targetPosition;
        }
    }
}
