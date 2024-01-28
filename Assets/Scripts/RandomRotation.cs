using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine;

public class RandomRotation : MonoBehaviour
{
    public float rotationSpeed = 50.0f;
    private Vector3 rotationDirection;

    void Start()
    {
        rotationDirection = Random.insideUnitSphere.normalized;
    }

    void Update()
    {
        transform.Rotate(rotationDirection * rotationSpeed * Time.deltaTime);
    }
}

