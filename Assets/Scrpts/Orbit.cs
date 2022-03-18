using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbit : MonoBehaviour
{
    public Transform rotatePoint;
    public Vector3 axis = Vector3.up;
    public float radius;
    public float radiusSpeed;
    public float rotationSpeed;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = (transform.position - rotatePoint.position).normalized * radius + rotatePoint.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(rotatePoint.position, axis, rotationSpeed * Time.deltaTime);
    }
}
