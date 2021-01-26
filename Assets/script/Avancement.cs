using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Avancement : MonoBehaviour
{
    public float zAcc;
    private float posZ;

    void Start()
    {
        posZ = transform.position.z;
    }

    void Update()
    {
        zAcc += 0.001f;
        posZ += Time.deltaTime * zAcc;
        transform.position = new Vector3(transform.position.x, transform.position.y, posZ);
    }
}